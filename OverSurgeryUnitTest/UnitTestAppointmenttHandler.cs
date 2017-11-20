using System;
using Tutorial1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAppointmenttHandler
{
    [TestClass]
    public class UnitTestAppointmentHandler
    {
        [TestMethod]
        public void TestAppointmentHandler()
        {
            DbConnector dbC = new DbConnector();
            string resp = dbC.connect();
            Assert.AreEqual("Done", resp);

            Appointment app = new Appointment();
            app.PatientID = 157;
            app.GpID = 1500344;
            app.NurseID = 400344;
            app.GpAvailability = "True";
            app.NurseAvailability = "True";
            app.CalenderDate = new DateTime(2017, 12, 23, 15, 30, 0);

            AppointmentHandler appointment = new AppointmentHandler();
            int resp2 = appointment.addNewAppointment(dbC.getConn(), app);
            Assert.IsNotNull(resp2);

        }
    }
}
