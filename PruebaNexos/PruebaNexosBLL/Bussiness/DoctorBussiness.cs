using PruebaNexosBLL.DAO;
using PruebaNexosServices;
using PruebaNexosServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNexosBLL.Bussiness
{
    internal class DoctorBussiness : IPruebaNexosDoctorServices
    {
        DoctorDAO doctorDAO = new DoctorDAO();
        public Doctor CreateDoctor(Doctor doctor)
        {
            try
            {
                return doctorDAO.CreateDoctor(doctor);
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
                return doctorDAO.DeleteDoctor(id);
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
                return doctorDAO.GetDoctor(id);
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
                return doctorDAO.GetDoctors();
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
                return doctorDAO.UpdateDoctor(doctor);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
