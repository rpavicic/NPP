using NPP.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.DbCnxt
{
    public class PrintViewerContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<PrintJob> PrintJobs { get; set; }
        public DbSet<Computer> Computers { get; set; }

        //public PrintViewerContext(string cs) : base(cs)
        public PrintViewerContext()
        {

        }
    }
}
