using PruebaNexosBLL.Context;
using PruebaNexosBLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNexosBLL.Assemblers
{
    public class ModelAssembler
    {
        public static List<Doctor> CreateDoctors(List<DoctorContext> doctorContexts)
        {
            List<Doctor> doctors = new List<Doctor>();
            foreach (DoctorContext doctorContext in doctorContexts)
            {
                doctors.Add(CreateDoctor(doctorContext));
            }
            return doctors;
        }

        public static Doctor CreateDoctor(DoctorContext doctorContext)
        {
            return new Doctor
            {
                Id = doctorContext.DoctorId,
                NameComplete = doctorContext.NameComplete,
                Specialty = doctorContext.Specialty,
                AccountNumber = doctorContext.AccountNumber,
                Hospital = doctorContext.Hospital
            };
        }
    }
}
