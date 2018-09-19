using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MyDemoApp
{
    /// <summary>
    /// Summary description for ByValByRefDemoService
    /// </summary>
    [WebService(Namespace = "http://www.timrobinson41tests.com/DemoProject")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ByValByRefDemoService : System.Web.Services.WebService
    {
        [WebMethod]
        public void Foo(int a, ref int b, out int c)
        {
            a++;
            b++;
            c = 10;
        }

        [WebMethod]
        public void Bar(Demo d1, ref Demo d2, out Demo d3)
        {
            d1.M1++;
            d2.M1++;
            d3 = new Demo();
            d3.M1 = 10;
        }
    }
}

public class Demo
{
    public int M1;
}
