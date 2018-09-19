using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyDemoAppWebClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        localhost.MathService ms = new localhost.MathService();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            var n1 = int.Parse(txtN1.Text);
            var n2 = int.Parse(txtN2.Text);
            lblResult.Text = ms.Add(n1, n2).ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            var n1 = int.Parse(txtN1.Text);
            var n2 = int.Parse(txtN2.Text);
            lblResult.Text = ms.Sub(n1, n2).ToString();
        }
    }
}