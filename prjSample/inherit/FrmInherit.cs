using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSample.inherit
{
    public partial class FrmInherit : Form
    {
        public FrmInherit()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A x = new A();
            x.m1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            B x = new B();
            x.m1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B x = new B("Hello"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            B x = new B();
            x.m2();
        }
    }
}
