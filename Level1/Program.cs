using System;
using System.Globalization;
using System.Threading;
using Level1.Commands;

namespace Level1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en");

            try
            {
                var comm = new Communicator();
                var settings = comm.GetInitial();

                var cmdTick = new TickCommand();


                if (!comm.ExecuteCommand(new ThrottleCommand(0, 0.1f)).Processed)
                {
                    Console.WriteLine("Throttle not accepted!");
                    return;
                }

                TickResponse tick = new TickResponse();
                var status = comm.ExecuteCommand(new StatusCommand(0));
                while (!tick.Success)
                {
                    tick = comm.ExecuteCommand(cmdTick);
                    status = comm.ExecuteCommand(new StatusCommand(0));
                    Console.WriteLine(status.Position.Z);
                    Console.WriteLine(status.Velocity.Z);
                }

                Console.Write("Done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}