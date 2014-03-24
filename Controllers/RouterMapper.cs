using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using DotNetNuke.Web.Api;

namespace TalkDotNet.Modules.DataExchange.Services
{
    public class RouterMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
                "DataExchange",
                "default", 
                "{controller}/{action}",
                new string[] { "TalkDotNet.Modules.DataExchange.Services" });
        }
    }
}