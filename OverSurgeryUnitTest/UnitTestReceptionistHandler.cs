using System;
using Tutorial1;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestReceptionistHandler
{
    [TestClass]
    public class UnitTestReceptionistHandler
    {
        [TestMethod]
        public void TestReceptionistHandler()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Receptionist recep = new Receptionist();
            recep.Name = "Michelle Chang";
            recep.Status = 1;
            recep.Datejoined = new DateTime(2017, 12, 23, 0, 0, 0);
            recep.LoginName = "michelle";
            recep.Password = "michelle123";

            ReceptionistHandler rHnd = new ReceptionistHandler();
            int resp2 = rHnd.addNewReceptionist(dbC.getConn(), recep);
            Assert.IsNotNull(resp2);
    }
    }
}
