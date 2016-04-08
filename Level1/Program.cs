using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using Level1.Commands;

namespace Level1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");

            TickResponse tick = new TickResponse();
            try
            {
                var comm = new Communicator();
                var settings = comm.GetInitial();

                var cmdTick = new TickCommand();


                if (!comm.ExecuteCommand(new ThrottleCommand(0, 0.6f)).Processed)
                {
                    Console.WriteLine("Throttle not accepted!");
                    return;
                }

                var status = comm.ExecuteCommand(new StatusCommand(0));
                while (!tick.Success)
                {
                    Console.WriteLine(comm.ExecuteCommand(new StatusCommand(0)));
                    tick = comm.ExecuteCommand(cmdTick);
                }

                Console.WriteLine("Finished within " + tick.Time);
            }
            catch (ParseException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}