using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LocalVisitTrack
{
    [ServiceContract]
    public interface IVisitTrackService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        bool Visit(string sysname, string modname);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]        
        bool Visit2(string sysname, string modname, string memo);

    }
    
}
