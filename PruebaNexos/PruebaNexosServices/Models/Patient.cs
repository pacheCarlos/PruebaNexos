using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNexosServices.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string NameComplete { get; set; }
        public int SocialSecurityNumber { get; set; }
        public int ZipCode { get; set; }
        public int Phone { get; set; }
    }
}
