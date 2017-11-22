using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OverSurgeryUnitTest
{
    public class MedicalPrescription
    {
        string prescriptionID;
        string patientID;
        string gpID;
        string patientDisease;
        int patientCondition;
        string drugPrescribed;

        public string PrescriptionID
        {
            get
            {
                return prescriptionID;
            }

            set
            {
                prescriptionID = value;
            }
        }

        public string PatientID
        {
            get
            {
                return patientID;
            }

            set
            {
                patientID = value;
            }
        }

        public string GpID
        {
            get
            {
                return gpID;
            }

            set
            {
                gpID = value;
            }
        }

        public string PatientDisease
        {
            get
            {
                return patientDisease;
            }

            set
            {
                patientDisease = value;
            }
        }

        public int PatientCondition
        {
            get
            {
                return patientCondition;
            }

            set
            {
                patientCondition = value;
            }
        }

        public string DrugPrescribed
        {
            get
            {
                return drugPrescribed;
            }

            set
            {
                drugPrescribed = value;
            }
        }
    }
}
