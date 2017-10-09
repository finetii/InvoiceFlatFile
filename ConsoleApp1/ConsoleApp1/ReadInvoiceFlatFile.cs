using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFlatFiles
{
    static class ReadInvoiceFlatFile
    {
        public static DeliveryNoteFile ReadFile(string filePath)
        {
            var Invoice = new DeliveryNoteFile();
            string line = null;

            StreamReader file = new StreamReader(filePath);
            Position pos = new Position();
            while ((line = file.ReadLine()) != null)
            {
                if (line.StartsWith("$$POS$$"))
                {
                    newPosition(Invoice, new Position(), line);
                }
                if (line.StartsWith("$$POS1$"))
                {
                    addToLastPosition(Invoice, line, 1);
                }
            }
            return Invoice;
        }

        private static void addToLastPosition(DeliveryNoteFile invoice, string line, int posLine)
        {
            Position pos = invoice.positions.Last();
            if (posLine == 1)
            {
                string delNote = line.Substring(pos.DeliveryQty.startPosition, pos.DeliveryQty.length);
                if (isDigit(delNote.Trim()))
                {
                    pos.DeliveryQty.Value = int.Parse(delNote);
                }
            }            
        }

        private static void newPosition(DeliveryNoteFile invoice, Position pos, string line)
        {
            string articleNo = line.Substring(pos.ArticleNo.startPosition, pos.ArticleNo.length);
            int i = Properties.Settings.Default.PZNStart;
            string articleName = line.Substring(pos.ArticleName.startPosition, pos.ArticleName.length);
            if (isDigit(articleNo))
                pos.ArticleNo.Value = int.Parse(articleNo);
            pos.ArticleName.Value = articleName;
            invoice.positions.Add(pos);
        }
        private static bool isDigit(string s)
        {
            int temp = 0;
            if (int.TryParse(s, out temp))
            {
                return true;
            }
            return false;
        }
    }
}
