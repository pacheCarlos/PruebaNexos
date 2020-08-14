using PruebaNexosBLL.Context;
using PruebaNexosServices.Models;
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

        public static PatientContext CreatePatientContext(Patient patient)
        {
            return new PatientContext
            {
                PatientId = patient.Id,
                NameComplete = patient.NameComplete,
                SocialSecurityNumber = patient.SocialSecurityNumber,
                ZipCode = patient.ZipCode,
                Phone = patient.Phone
            };
        }
    }
}
