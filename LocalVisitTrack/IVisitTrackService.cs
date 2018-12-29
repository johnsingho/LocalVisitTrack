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
        //[WebInvoke(Method ="GET", ResponseFormat=WebMessageFormat.Json, BodyStyle=WebMessageBodyStyle.Wrapped)]
        string GetData(int value);

    }
    
}
