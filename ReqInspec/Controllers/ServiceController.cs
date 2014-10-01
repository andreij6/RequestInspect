using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml;

namespace ReqInspec.Controllers
{
    [AllowAnonymous]
    [RoutePrefix("test")]
    public class ServiceController : ApiController
    {
        
        [Route("VerifyAddress")]
        [HttpPost]
        public HttpResponseMessage VerifyAddress()
        {
            string result =
                        @"<?xml version=""1.0"" encoding=""utf-8""?>" +
                            @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">" +
                                "<soapenv:Body>" +
                                @"<notificationsResponse xmlns=""http://soap.sforce.com/2005/09/outbound"">" +
                                    @"<Ack>true</Ack>" +
                                "</notificationsResponse>" +
                            "</soapenv:Body>" +
                        "</soapenv:Envelope>";
            //string result =
            //        @"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"">" +
            //            "<soapenv:Body>" +
            //                @"<notificationsResponse xmlns=""http://soap.sforce.com/2005/09/outbound"">" +
            //                    "<Ack>true</Ack>" +
            //                "</notificationsResponse>" +
            //            "</soapenv:Body>" +
            //        "</soapenv:Envelope>";
            XmlDocument response = new XmlDocument();
            response.LoadXml(result);

            return new HttpResponseMessage() { Content = new StringContent(response.OuterXml) };
        }
    }
}
