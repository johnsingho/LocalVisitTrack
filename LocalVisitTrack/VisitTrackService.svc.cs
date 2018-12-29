using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace LocalVisitTrack
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class VisitTrackService : IVisitTrackService
    {
        public string GetData(int value)
        {
            //test: http://localhost:55833/VisitTrackService.svc/VisitTrackWeb/GetData?value=721
            //result: {"GetDataResult":"返回You entered: 721"}
            return string.Format("返回You entered: {0}", value);
        }
        
    }
}
