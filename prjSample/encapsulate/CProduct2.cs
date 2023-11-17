using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjSample.encapsulate
{
    public class CProduct2
    {
        private string _barcode;
        private string _name;
        private decimal _price;
        public string barcode
        {
            get { return _barcode; }
            set { _barcode = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public decimal price
        {
            get
            {
                if (_price < 80)
                    return 80;
                return _price; }
            set { _price = value; }
        }
    }
}
