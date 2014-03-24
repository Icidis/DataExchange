using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Net.Http;
using DotNetNuke.Web.Api;
using System.Web.Http;
using System.Net;
using DotNetNuke.Services.Exceptions;

namespace TalkDotNet.Modules.DataExchange.Services
{
    public class ExampleController : ControllerBase
    {
        #region "Web Methods"
        [DnnAuthorize()]
        [HttpGet()]
        public HttpResponseMessage HelloWorld()
        {
            try
            {
                string helloWorld = "Hello World!";
                return Request.CreateResponse(HttpStatusCode.OK, helloWorld);
            }
            catch (System.Exception ex)
            {
                //Log to DotNetNuke and reply with Error
                Exceptions.LogException(ex);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [DnnAuthorize()]
        [HttpPost()]
        [ValidateAntiForgeryToken()]
        public HttpResponseMessage GoodbyeWorld(DTOWorldDetails data)
        {
            try
            {
                string helloWorld = "Hello World!";
                if (data.goodbye)
                {
                    helloWorld = "Good-bye World!";
                }
                return Request.CreateResponse(HttpStatusCode.OK, helloWorld);
            }
            catch (System.Exception ex)
            {
                //Log to DotNetNuke and reply with Error
                Exceptions.LogException(ex);
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        #endregion

        #region "DTO Classes"
        public class DTOWorldDetails
        {
            public bool goodbye { get; set; }
        }
        #endregion
    }
}