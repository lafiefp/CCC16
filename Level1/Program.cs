using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Level1.Commands;

namespace Level1
{
    class Program
    {
        static void Main(string[] args)
        {
            var comm = new Communicator();
            comm.GetInitial();
            var status = comm.ExecuteCommand(new StatusCommand(0));
            Console.Write("Done");
        }
    }
}
