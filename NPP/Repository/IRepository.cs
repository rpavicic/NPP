using NPP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.Repository
{
    public interface IRepository
    {
        User GetUserByUid(string uid);
        Printer GetPrinterByName(string name);
        Computer GetComputerByName(string name);
        void AddUser(User user);
        void AddPrinter(Printer printer);
        void AddComputer(Computer computer);
        void AddPrintJob(PrintJob printJob);
    }
}
