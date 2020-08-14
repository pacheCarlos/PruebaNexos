using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaNexosBLL.Context
{
    public class PatientContext
    {
        [Key]
        public int PatientId { get; set; }
        public string NameComplete { get; set; }
        public int SocialSecurityNumber { get; set; }
        public int ZipCode { get; set; }
        public int Phone { get; set; }

        public ICollection<DoctorPatientContext> DoctorPatientContexts { get; set; }
    }
}
