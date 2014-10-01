using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReqInspec.Controllers
{
    public class ServiceController : ApiController
    {
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
