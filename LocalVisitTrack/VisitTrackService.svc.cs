using LocalVisitTrack.BLL;
using System.ServiceModel;
using System.ServiceModel.Activation;

namespace LocalVisitTrack
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class VisitTrackService : IVisitTrackService
    {
        public bool Visit(string sysname, string modname,string loginuser)
        {
            return Visit2(sysname, modname, loginuser, string.Empty);
        }

        public bool Visit2(string sysname, string modname, string loginuser, string memo)
        {
            //test: http://dmnnt022:9900/VisitTrackService.svc/VisitTrackWeb/Visit?sysname=Test&modname=test123
            //test: http://localhost:55833/VisitTrackService.svc/VisitTrackWeb/Visit?sysname=Test&modname=test123
            return VisitTrackDAL.Visit(sysname, modname, loginuser, memo);
        }
        //public string GetData(int value)
        //{
        //    //test: http://localhost:55833/VisitTrackService.svc/VisitTrackWeb/GetData?value=721
        //    //result: {"GetDataResult":"返回You entered: 721"}
        //    return string.Format("返回You entered: {0}", value);
        //}

    }
}
