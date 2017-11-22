using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;
using OverSurgery;

namespace OverSurgeryUnitTest
{
    [TestClass]
    public class UniTestMedicalPrecriptionHandler
    {
        [TestMethod]
        public void TestAddNewMP()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            MedicalPrescription medp = new MedicalPrescription();
            medp.PrescriptionID = "944512";
            medp.PatientID = "J7724";
            medp.GpID = "1234567";
            medp.PatientDisease = "enzyma";
            medp.PatientCondition = 2;
            medp.DrugPrescribed = "antibiotic";

            MedicalPrescriptionHandler mpHnd = new MedicalPrescriptionHandler();
            int resp2 = mpHnd.addNewMP(dbC.getConn(), medp);
        }
    }
}
