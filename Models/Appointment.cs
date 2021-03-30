using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMedical.Models
{
    public class Appointment
    {
        [Key]
        public int appointment_id { get; set; }
        public DateTime date { get; set; }
        public string note { get; set; }

        public int? patient_id { get; set; }
        [JsonIgnore]
        public Patient Patient { get; set; }
    }
}