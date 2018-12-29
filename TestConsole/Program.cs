using LocalVisitTrack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var visitTrack = new VisitTrackService();
            var s1 = visitTrack.GetData(123);
            var s2 = visitTrack.GetData(77);
            Console.WriteLine("values = {0}, {1}", s1, s2);
            Console.Read();
        }
    }
}
