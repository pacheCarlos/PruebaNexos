using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNexosBLL.Context
{
    public class DoctorPatientContext
    {
        public int DoctorId { get; set; }
        public DoctorContext Doctor { get; set; }
        public int PatientId { get; set; }
        public PatientContext Patient { get; set; }
    }
}
