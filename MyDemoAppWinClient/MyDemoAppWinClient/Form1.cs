using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDemoAppWinClient
{
    public partial class Form1 : Form
    {
        private localhost.MathService ms = new localhost.MathService();
        localhost.UserInfoHeader ui = new localhost.UserInfoHeader();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);

            MessageBox.Show(ms.Add(n1, n2).ToString());
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            MessageBox.Show(ms.Sub(n1, n2).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ui.Username = "Demo";
            ui.Password = "Demo";
            ms.UserInfoHeaderValue = ui;
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ms.GetCount().ToString());
        }

        private void btnAddAsync_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtN1.Text);
            int n2 = int.Parse(txtN2.Text);
            ms.AddCompleted += new localhost.AddCompletedEventHandler(ms_AddCompleted);
            ms.AddAsync(n1, n2);

        }

        void ms_AddCompleted(object sender, localhost.AddCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
        }

        private void btnSayHello_Click(object sender, EventArgs e)
        {
            localhost1.AuthDemoService ad = new localhost1.AuthDemoService();
            //ad.Credentials = System.Net.CredentialCache.DefaultCredentials;
            System.Net.NetworkCredential nc = new System.Net.NetworkCredential("timro", "DAnza#66");
            System.Net.CredentialCache cc = new System.Net.CredentialCache();
            cc.Add(new Uri(ad.Url), "ntlm", nc);
            ad.Credentials = cc;
            MessageBox.Show(ad.SayHello());
        }
    }
}
