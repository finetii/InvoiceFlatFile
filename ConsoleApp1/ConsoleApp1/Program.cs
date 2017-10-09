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
            string path = @"D:\Documents\GitHub\InvoiceFlatFile\ConsoleApp1\ConsoleApp1\bin\Debug\invoice-7001988-3002296364.txt";
            if (args != null && args.Length != 0)
            {
                path = args[0];                
                Console.WriteLine(path);
            }            
            
            var Invoice = ReadInvoiceFlatFile.ReadFile(path);
            foreach (var position in Invoice.positions)
            {
                Console.WriteLine(position.ToString());
            }
            Console.ReadLine();
        }
        

    }
}
