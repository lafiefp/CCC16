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

            var comm = new Communicator();
            var settings = comm.GetInitial();
            var status = comm.ExecuteCommand(new StatusCommand(0));
            Console.Write("Done");
        }
    }
}