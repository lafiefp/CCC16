using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Level1.Commands;

namespace Level1
{
    class Level1
    {
        public static void Execute()
        {
            var comm = new Communicator();
            var settings = comm.GetInitial();

            var cmdTick = new TickCommand();
            if (!comm.ExecuteCommand(new ThrottleCommand(0, 0.6f)).Processed)
            {
                Console.WriteLine("Throttle not accepted!");
                return;
            }

            TickResponse tick = new TickResponse();
            var status = comm.ExecuteCommand(new StatusCommand(0));
            while (!tick.Success)
            {
                Console.WriteLine(comm.ExecuteCommand(new StatusCommand(0)));
                tick = comm.ExecuteCommand(cmdTick);
            }

            Console.WriteLine("Finished within " + tick.Time);
        }
    }
}
