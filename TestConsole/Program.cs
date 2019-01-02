using System;
using TestConsole.ServiceReference1;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var visitTrack = new VisitTrackServiceClient();
            var s0 = visitTrack.Visit("项目一", "模块一", "登录用户名");

            var s1 = visitTrack.Visit("测试", "Console", "");
            var s2 = visitTrack.Visit2("测试", "Console2", "", "备注内容");
            Console.WriteLine("values = {0}, {1}", s1, s2);
            Console.Read();
        }
    }
}
