using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyDemoApp
{
    /// <summary>
    /// Summary description for AuthDemoService
    /// </summary>
    [WebService(Namespace = "http://www.timrobinson41tests.com/DemoProject")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AuthDemoService : System.Web.Services.WebService
    {
        [WebMethod]
        public string SayHello()
        {
            return "Hello " + User.Identity.Name;
        }
    }
}
