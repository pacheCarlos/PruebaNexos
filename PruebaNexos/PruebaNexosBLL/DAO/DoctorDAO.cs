using PruebaNexosBLL.Assemblers;
using PruebaNexosBLL.Context;
using PruebaNexosServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaNexosBLL.DAO
{
    public class DoctorDAO
    {
        public Doctor CreateDoctor(Doctor doctor)
        {
            try
            {
                DoctorContext doctorContext = EntityAssembler.CreateDoctorContext(doctor);
                using (var context = new HospitalContext())
                {
                    context.DoctorContexts.Add(doctorContext);
                    context.SaveChanges();
                }
                return doctor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Doctor UpdateDoctor(Doctor doctor)
        {
            try
            {
                using (var context = new HospitalContext())
                {
                    DoctorContext doctorContext = context.DoctorContexts.Find(doctor.Id);
                    doctorContext.NameComplete = doctor.NameComplete;
                    doctorContext.Specialty = doctor.Specialty;
                    doctorContext.AccountNumber = doctor.AccountNumber;
                    doctorContext.Hospital = doctor.Hospital; 
                    context.SaveChanges();
                }
                return doctor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteDoctor(int id)
        {
            try
            {
                using (var context = new HospitalContext())
                {
                    DoctorContext doctorContext = context.DoctorContexts.Find(id);
                    context.Remove(doctorContext);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Doctor GetDoctor(int id)
        {
            try
            {
                Doctor doctorResult = null;
                using (var context = new HospitalContext())
                {
                    DoctorContext doctorContext = context.DoctorContexts.Find(id);
                    doctorResult = ModelAssembler.CreateDoctor(doctorContext);
                }
                return doctorResult;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Doctor> GetDoctors()
        {
            try
            {
                List<Doctor> doctorResult = null;
                using (var context = new HospitalContext())
                {
                    List<DoctorContext> doctorContexts = context.DoctorContexts.ToList();
                    doctorResult = ModelAssembler.CreateDoctors(doctorContexts);
                }
                return doctorResult;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
