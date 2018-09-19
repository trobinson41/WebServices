using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByValByRefServiceClient
{
    public partial class Form1 : Form
    {
        localhost.ByValByRefDemoService service = new localhost.ByValByRefDemoService();

        public Form1()
        {
            InitializeComponent();
        }

        private void Bar(Demo d1, ref Demo d2, out Demo d3)
        {
            d1.M1++;
            d2.M1++;
            d3 = new Demo();
            d3.M1 = 10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 2;
            int b = 2;
            int c = 2;

            c = service.Foo(a, ref b);

            MessageBox.Show($"a: {a}, b: {b}, c: {c}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Demo d4 = new Demo();
            Demo d5 = new Demo();
            Demo d6 = new Demo();
            d4.M1 = 2;
            d5.M1 = 2;
            d6.M1 = 2;

            Bar(d4, ref d5, out d6);

            MessageBox.Show($"d4.M1: {d4.M1}, d5.M1: {d5.M1}, d6.M1: {d6.M1}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            localhost.Demo d1 = new localhost.Demo();
            localhost.Demo d2 = new localhost.Demo();
            localhost.Demo d3 = new localhost.Demo();
            d1.M1 = 2;
            d2.M1 = 2;
            d3.M1 = 2;

            d3 = service.Bar(d1, ref d2);

            MessageBox.Show($"d1.M1: {d1.M1}, d2.M1: {d2.M1}, d3.M1: {d3.M1}");
        }
    }

    class Demo
    {
        public int M1;
    }
}
