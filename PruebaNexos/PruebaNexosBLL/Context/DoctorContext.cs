using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaNexosBLL.Context
{
    public class DoctorContext
    {
        [Key]
        public int DoctorId { get; set; }
        public string NameComplete { get; set; }
        public string Specialty { get; set; }
        public int AccountNumber { get; set; }
        public string Hospital { get; set; }

        public ICollection<DoctorPatientContext> DoctorPatientContexts { get; set; }
    }
}
