using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Patient
    {
        public Patient() 
        {
            doctors = new List<Doctor>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        
        public string PatientName { get; set; }
        [Display(Name = "Код на пациент")]
        [Range(10000,99999,ErrorMessage = "Кодот на пациентот мора да е со 5 бројки!")]
        public string PatientCode { get; set;}

        public string Gender { get; set; }

        public string Age { get; set;}

        public virtual ICollection<Doctor> doctors { get;}
    }
}