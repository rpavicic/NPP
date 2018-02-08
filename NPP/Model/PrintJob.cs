using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.Model
{
    public class PrintJob
    {
        /*private DateTime fieldDate;
private Printer printerObj;
private string document;
private Computer computerrObj;*/

        public PrintJob(User user, int pages, int copies, Printer printerObj, string document, Computer computerrObj, string paperSize, string printLanguage, string height, string width, bool duplex, bool grayscale, string documentSize)
        {
            //Time = fieldDate;
            User = user;
            Pages = pages;
            Copies = copies;
            Printer = printerObj;
            DocumentName = document;
            Computer = computerrObj;
            PaperSize = paperSize;
            PrintLanguage = printLanguage;
            Height = height;
            Width = width;
            Duplex = duplex;
            Grayscale = grayscale;
            DocumentSize = documentSize;
        }

        public int Id { get; set; }
        //DateTime Time { get; set; }
        public User User { get; set; }
        public int Pages { get; set; }
        public int Copies { get; set; }
        public Printer Printer { get; set; }
        public string DocumentName { get; set; }
        public Computer Computer { get; set; }
        public string PaperSize { get; set; }
        public string PrintLanguage { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
        public bool Duplex { get; set; }
        public bool Grayscale { get; set; }
        public string DocumentSize { get; set; }
    }
}
