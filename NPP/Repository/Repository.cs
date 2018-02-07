using NPP.DbCnxt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.Repository
{
    public class Repository:IRepository
    {
        private PrintViewerContext _cntx;

        public Repository(PrintViewerContext cntx)
        {
            _cntx = cntx;
        }


    }
}
