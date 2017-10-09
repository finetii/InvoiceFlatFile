using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFlatFiles
{
    class DeliveryNoteFile
    {
        public Supplier supplier { get; set; }
        public Header header { get; set; }
        public List<Position> positions { get; set; }
        public VATTable vat { get; set; }
        

        public DeliveryNoteFile()
        {
            supplier = new Supplier();
            header = new Header();
            positions = new List<Position>();
            vat = new VATTable();
        }
    }
}
