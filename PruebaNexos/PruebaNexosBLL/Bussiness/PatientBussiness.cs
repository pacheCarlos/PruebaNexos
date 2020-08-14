using System;
using System.Collections.Generic;
using System.Text;
using PruebaNexosBLL.DAO;
using PruebaNexosServices;
using PruebaNexosServices.Models;

namespace PruebaNexosBLL.Bussiness
{
    internal class PatientBussiness : IPruebaNexosPatientServices
    {
        PatientDAO patientDAO = new PatientDAO();
        public Patient CreatePatient(Patient patient)
        {
            try
            {
                return patientDAO.CreatePatient(patient);
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
                return patientDAO.DeletePatient(id);
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
                return patientDAO.GetPatient(id);
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
                return patientDAO.GetPatient();
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
                return patientDAO.UpdatePatient(patient);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
