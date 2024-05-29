using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Doctor
    {

        public Doctor() 
        {
            patients = new List<Patient>(); 
        }

        [Key]
        public int Id { get; set; }

        public string DoctorName { get; set; }

        public string Age { get; set; }

        public string Gender { get; set;}

        public Hospital Hospital { get; set; }

        public virtual ICollection<Patient> patients { get; set; }
    }
}