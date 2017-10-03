using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFlatFiles
{
    class InvoiceInfo
    {
        public Supplier supplier { get; set; }
        public Header header { get; set; }
        public List<Position> positions { get; set; }
        public VAT vat { get; set; }
        public int MyProperty { get; set; }

        public InvoiceInfo()
        {
            supplier = new Supplier();
            header = new Header();
            positions = new List<Position>();
            vat = new VAT();
        }
    }
}
