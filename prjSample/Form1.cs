using prjSample.constructor;
using prjSample.encapsulate;
using prjSample.inherit;
using prjSample.ns;
using prjSample.partial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prjSample.partial.A x = new prjSample.partial.A();
            x.m3();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prjSample.partial.A.VERSION = 1;
            MessageBox.Show("目前版本：" + prjSample.partial.A.VERSION.ToString("0.0"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmNamespace f = new FrmNamespace();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmEncapsulate f = new FrmEncapsulate();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new FrmConstructor()).Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            (new FrmInherit()).Show();
        }
    }
}
