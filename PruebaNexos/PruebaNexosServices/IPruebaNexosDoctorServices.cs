using PruebaNexosServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNexosServices
{
    public interface IPruebaNexosDoctorServices
    {
        Doctor CreateDoctor(Doctor doctor);
        Doctor UpdateDoctor(Doctor doctor);
        bool DeleteDoctor(int id);
        Doctor GetDoctor(int id);
        List<Doctor> GetDoctors();
    }
}
