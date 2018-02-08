using NPP.DbCnxt;
using NPP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.Repository
{
    public class CntxRepository:IRepository
    {
        private PrintViewerContext _cntx;

        public CntxRepository(PrintViewerContext cntx)
        {
            _cntx = cntx;
        }

        public void AddComputer(Computer computer)
        {
            _cntx.Computers.Add(computer);
            _cntx.SaveChanges();
        }

        public void AddPrinter(Printer printer)
        {
            _cntx.Printers.Add(printer);
            _cntx.SaveChanges();
        }

        public void AddUser(User user)
        {
            _cntx.Users.Add(user);
            _cntx.SaveChanges();
        }

        public Computer GetComputerByName(string name)
        {
            var computer = _cntx.Computers.Where(c => c.Name.Equals(name)).FirstOrDefault();
            if (computer == null)
            {
                computer = new Computer { Name = name };
            }
            return computer;
        }

        public Printer GetPrinterByName(string name)
        {
            var printer = _cntx.Printers.Where(p => p.Name.Equals(name)).FirstOrDefault();
            if (printer == null)
            {
                printer = new Printer { Name = name };
            }
            return printer;
        }

        public User GetUserByUid(string uid)
        {
            var user = _cntx.Users.Where(u => u.Uid.Equals(uid)).FirstOrDefault();
            if (user == null)
            {
                user = new User { Uid = uid };
            }
            return user;
        }
    }
}
