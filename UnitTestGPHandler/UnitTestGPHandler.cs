using System;
using OverSurgery;
using MySql;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGPHandler
{
    [TestClass]
    public class UnitTestGPHandler
    {
        [TestMethod]
        public void TestGPHandler()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            GeneralPractitioner gp = new GeneralPractitioner();
            gp.Name = "Hector Barbossa";
            gp.Status = 1;
            gp.DateJoined = new DateTime(2017, 11, 13, 0, 0, 0);
            gp.LoginName = "hector";
            gp.Password = "hector123"; 

            GPHandler gHnd = new GPHandler();
            int resp2 = gHnd.addNewGP(dbC.getConn(), gp);

        }
    }
}
