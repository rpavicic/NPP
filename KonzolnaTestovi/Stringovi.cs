using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonzolnaTestovi
{
    public class Stringovi
    {
        public Stringovi()
        {

        }

        public string SloziRecenicuOdRijeci(string[] rijeci)
        {
            string recenica = "";
            foreach (var item in rijeci)
            {
                recenica += item + " ";
            }
            return (recenica.Trim())+".";
        }
    }
}
