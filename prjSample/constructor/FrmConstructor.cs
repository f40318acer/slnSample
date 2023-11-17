using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSample.constructor
{
    public partial class FrmConstructor : Form
    {
        public FrmConstructor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A x = null;
            x=new A("Hello");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            A x = null;
            x=new A(8);
        }
    }
}
