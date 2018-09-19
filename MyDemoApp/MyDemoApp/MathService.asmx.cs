using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace MyDemoApp
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://www.timrobinson41tests.com/DemoProject")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class MathService : System.Web.Services.WebService
    {
        public UserInfoHeader ui;

        [WebMethod]
        [SoapHeader("ui", Direction=SoapHeaderDirection.InOut)]
        public int Add(int a, int b)
        {
            if (ui.Username != ui.Password)
                throw new ApplicationException("Invalid Username or Password");
            ui.Count++;
            System.Threading.Thread.Sleep(5000);
            return a + b;
        }
        [WebMethod]
        [SoapHeader("ui", Direction = SoapHeaderDirection.InOut)]
        public int Sub(int a, int b)
        {
            if (ui.Username != ui.Password)
                throw new ApplicationException("Invalid Username or Password");
            ui.Count++;
            return a - b;
        }
        [WebMethod]
        [SoapHeader("ui", Direction = SoapHeaderDirection.InOut)]
        public int GetCount()
        {
            return ui.Count;
        }
    }

    public class UserInfoHeader : SoapHeader
    {
        public string Username, Password;
        public int Count;
    }
}

