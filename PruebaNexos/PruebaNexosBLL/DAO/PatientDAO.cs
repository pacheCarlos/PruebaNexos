using PruebaNexosBLL.Assemblers;
using PruebaNexosBLL.Context;
using PruebaNexosServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaNexosBLL.DAO
{
    public class PatientDAO
    {
        public Patient CreatePatient(Patient patient)
        {
            try
            {
                PatientContext patientContext = EntityAssembler.CreatePatientContext(patient);
                using (var context = new HospitalContext())
                {
                    context.PatientContexts.Add(patientContext);
                    context.SaveChanges();
                }
                return patient;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Patient UpdatePatient(Patient patient)
        {
            try
            {
                using (var context = new HospitalContext())
                {
                    PatientContext patientContext = context.PatientContexts.Find(patient.Id);
                    patientContext.NameComplete = patient.NameComplete;
                    patientContext.SocialSecurityNumber = patient.SocialSecurityNumber;
                    patientContext.ZipCode = patient.ZipCode;
                    patientContext.Phone = patient.Phone;
                    context.SaveChanges();
                }
                return patient;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeletePatient(int id)
        {
            try
            {
                using (var context = new HospitalContext())
                {
                    PatientContext patientContext = context.PatientContexts.Find(id);
                    context.Remove(patientContext);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Patient GetPatient(int id)
        {
            try
            {
                Patient patientResult = null;
                using (var context = new HospitalContext())
                {
                    PatientContext patientContext = context.PatientContexts.Find(id);
                    patientResult = ModelAssembler.CreatePatient(patientContext);
                }
                return patientResult;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Patient> GetPatient()
        {
            try
            {
                List<Patient> patientResult = null;
                using (var context = new HospitalContext())
                {
                    List<PatientContext> patientContexts = context.PatientContexts.ToList();
                    patientResult = ModelAssembler.CreatePatients(patientContexts);
                }
                return patientResult;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
