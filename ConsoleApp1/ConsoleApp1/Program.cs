using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFlatFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\fina.meranzova\Desktop\invoice-2051510-1003319729.txt";
            var Invoice = ReadInvoiceFlatFile.ReadFile(path);
            foreach (var position in Invoice.positions)
            {
                Console.WriteLine(position.ToString());
            }
        }
        

    }
}
