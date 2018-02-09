using Microsoft.VisualStudio.TestTools.UnitTesting;
using NPP.DbCnxt;
using NPP.Model;
using NPP.Repository;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPP.Repository.Tests
{
    public class EffortProviderFactory : IDbConnectionFactory
    {
        private static DbConnection _connection;
        private readonly static object _lock = new object();

        public static void ResetDb()
        {
            lock (_lock)
            {
                _connection = null;
            }
        }

        public DbConnection CreateConnection(string nameOrConnectionString)
        {
            lock (_lock)
            {
                if (_connection == null)
                {
                    _connection = Effort.DbConnectionFactory.CreateTransient();
                }

                return _connection;
            }
        }
    }


    [TestClass()]
    public class TestsInitialize
    {
        [AssemblyInitialize]
        public static void AssemblyInit(TestContext context)
        {
            Effort.Provider.EffortProviderConfiguration.RegisterProvider();
        }
    }

    public class CntxRepositoryTests
    {
        [TestMethod()]
        public void CntxRepositoryTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddComputerTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddPrintJobTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddPrinterTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddUserTest()
        {
            Assert.Fail();
        }

        [TestInitialize]
        public void MyTestInitialize()
        {
            EffortProviderFactory.ResetDb();
        }

        [TestMethod()]
        public void GetComputerByNameTestIsNullIfNotExistsInDB()
        {
            PrintViewerContext cntx = new PrintViewerContext();
            CntxRepository repository = new CntxRepository(cntx);
            Computer currentComputer = null;

            Computer computer = repository.GetComputerByName("izmisljeno");

            Assert.AreEqual(currentComputer, computer);


            //Assert.Fail();
        }

        [TestMethod()]
        public void GetPrinterByNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUserByUidTest()
        {
            Assert.Fail();
        }
    }
}