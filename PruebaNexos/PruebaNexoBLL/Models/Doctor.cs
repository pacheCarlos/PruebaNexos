using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNexosBLL.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string NameComplete { get; set; }
        public string Specialty { get; set; }
        public int AccountNumber { get; set; }
        public string Hospital { get; set; }
    }
}
