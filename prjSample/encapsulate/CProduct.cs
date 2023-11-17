using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSample.encapsulate
{
    public  class CProduct
    {
        private string barcode;
        public void setBarcode(string p)
        {
            barcode = p;
        }
        public string getBarcode()
        {
            return barcode;
        }
        private string name;
        public void setName(string p)
        {
            name = p;
        }
        public string getName()
        {
            return name;
        }
        private decimal price;
        public void setPrice(decimal p)
        {
            price = p;
        }
        public decimal getPrice()
        {
            if (price < 80)
                return 80;
            return price;
        }
    }
}
