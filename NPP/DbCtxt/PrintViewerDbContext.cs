using NPP.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.DbCtxt
{
    public class PrintViewerDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<PrintJob> PrintJobs { get; set; }
        public DbSet<Computer> ComputerNames { get; set; }
    }
}
