using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class DoctorPatient
    {
        public DoctorPatient() 
        {
            patients = new List<Patient>(); 
        }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public List<Patient> patients { get; set; }
    }
}