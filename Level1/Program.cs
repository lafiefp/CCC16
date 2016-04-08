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

            try
            {
                Level1.Execute();
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