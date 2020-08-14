using PruebaNexosBLL.Context;
using PruebaNexosBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNexosBLL.Assemblers
{
    public static class EntityAssembler
    {
        public static DoctorContext CreateDoctorContext(Doctor doctor)
        {
            return new DoctorContext
            {
                DoctorId = doctor.Id,
                NameComplete = doctor.NameComplete,
                Specialty = doctor.Specialty,
                AccountNumber = doctor.AccountNumber,
                Hospital = doctor.Hospital
            };
        }
    }
}
