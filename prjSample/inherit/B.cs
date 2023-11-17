using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSample.inherit
{
    public class B:A
    {
        public B():base("hello")
        {
            MessageBox.Show("B 類別的預設建構子");
        }
        public B(string p)
        {
            MessageBox.Show("B 類別，string 建構子");
        }
        public void m1()
        {
            MessageBox.Show("426");
        }
        public void m2()
        {
            base.m1();
            this.m1();
        }
    }
    
}
