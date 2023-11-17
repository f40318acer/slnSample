using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjSample.constructor
{
    public class A
    {
        public A(string p)
        {
            MessageBox.Show("A 類別被載入記憶體," + p);
        }
        public A(int p)
        {
            MessageBox.Show("A 類別被載入記憶體,int參數" + p.ToString());
        }

    }
}
