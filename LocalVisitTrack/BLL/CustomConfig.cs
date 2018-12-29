using System.Configuration;

namespace LocalVisitTrack.BLL
{
    public class CustomConfig
    {
        public static string ConnStrMain;
        static CustomConfig()
        {
            ConnStrMain = ConfigurationManager.ConnectionStrings["main_ConnStr"].ConnectionString;

        }
    }
}