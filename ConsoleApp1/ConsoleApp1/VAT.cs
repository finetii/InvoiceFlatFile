using System.Collections.Generic;

namespace ReadFlatFiles
{
    public class VAT
    {
        public decimal Percentage { get; set; }
        public decimal Value { get; set; }
    }

    public class VATTable
    {
        public decimal Value
        { get
            {
                if (!(Table is null))
                {
                    decimal val = 0;
                    foreach (var item in Table)
                    {
                        val += item.Value;
                    }
                    return val;
                }
                else
                    return 0;
            }
        }

        public List<VAT> Table;
        public VATTable()
        {
            Table = new List<VAT>();
        }
    }
}