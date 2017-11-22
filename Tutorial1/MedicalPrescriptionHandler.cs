using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace OverSurgeryUnitTest
{
    public class MedicalPrescriptionHandler
    {
        public int addNewMP(MySqlConnection conn, MedicalPrescription mp)
        {
            string sql = "INSERT INTO medical_prescription (prescriptionID, patientID, gpID, patientDisease, patientCondition, drugPrescribed) " + " VALUES ('" + mp.PrescriptionID + "'," + mp.PatientID + ", '" + mp.GpID + "," + mp.PatientDisease + "'," + mp.PatientCondition + "'," + mp.DrugPrescribed + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            return cmd.ExecuteNonQuery();
        }
    }
}
