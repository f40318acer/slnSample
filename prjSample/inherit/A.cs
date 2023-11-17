using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSample.inherit
{
    public sealed class A
    {
        public A(string p)
        {
            MessageBox.Show("A 類別，string 建構子");
        }
        public A()
        {
            MessageBox.Show("A 類別的預設建構子");
        }
        public void m1()
        {
            MessageBox.Show("26");
        }
    }
}
