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
        List<PrintJob> GetAllPrintJobs();
        List<User> GetAllUsers();
        void EditUser(User user);
        List<Computer> GetAllComputers();
        void EditComputer(Computer comp);
        List<Printer> GetAllPrinters();
        void EditPrinter(Printer printer);
    }
}
