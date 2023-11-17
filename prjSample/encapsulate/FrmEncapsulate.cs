using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSample.encapsulate
{
    public partial class FrmEncapsulate : Form
    {
        public FrmEncapsulate()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            A x = new A();
            x.a = 8;
            MessageBox.Show(x.a.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CProduct x = new CProduct();
            x.setBarcode( "4710123");
            x.setName( "味全化工茶");
            x.setPrice(120);

            string s = "產品資訊\r\n==============";
            s += "\r\n條碼：" + x.getBarcode();
            s += "\r\n品名：" + x.getName();
            s += "\r\n售價：$" + x.getPrice().ToString();
            s += "\r\n==============";
            MessageBox.Show(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CProduct2 x = new CProduct2();
            x.barcode="4710123";
            x.name="味全化工茶";
            x.price=-120;

            string s = "產品資訊\r\n==============";
            s += "\r\n條碼：" + x.barcode;
            s += "\r\n品名：" + x.name;
            s += "\r\n售價：$" + x.price.ToString();
            s += "\r\n==============";
            MessageBox.Show(s);
        }
    }
}
