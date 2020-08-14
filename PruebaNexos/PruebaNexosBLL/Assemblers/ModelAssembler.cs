using PruebaNexosBLL.Context;
using PruebaNexosServices.Models;
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

        public static List<Patient> CreatePatients(List<PatientContext> patientContexts)
        {
            List<Patient> patients = new List<Patient>();
            foreach (PatientContext patientContext in patientContexts)
            {
                patients.Add(CreatePatient(patientContext));
            }
            return patients;
        }

        public static Patient CreatePatient(PatientContext patientContext)
        {
            return new Patient
            {
                Id = patientContext.PatientId,
                NameComplete = patientContext.NameComplete,
                SocialSecurityNumber = patientContext.SocialSecurityNumber,
                ZipCode = patientContext.ZipCode,
                Phone = patientContext.Phone
            };
        }
    }
}
