using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReqInspec.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("test")]
    public class ServiceController : ApiController
    {
        
        [Route("VerifyAddress")]
        [HttpPost]
        public string VerifyAddress()
        {
            string result =
                    @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"">" +
                        "<soapenv:Body>" +
                            @"<notificationsResponse xmlns=""http://soap.sforce.com/2005/09/outbound"">" +
                                "<Ack>true</Ack>" +
                            "</notificationsResponse>" +
                        "</soapenv:Body>" +
                    "</soapenv:Envelope>";

            return result;
        }
    }
}
