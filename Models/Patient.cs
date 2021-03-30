using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMedical.Models
{
    public class Patient
    {
        [Key]
        public int patient_id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}