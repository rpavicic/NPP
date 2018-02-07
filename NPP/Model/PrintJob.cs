using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.Model
{
    public class PrintJob
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
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
