using PruebaNexosServices.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaNexosServices
{
    public interface IPruebaNexosPatientServices
    {
        Patient CreatePatient(Patient patient);
        Patient UpdatePatient(Patient patient);
        bool DeletePatient(int id);
        Patient GetPatient(int id);
        List<Patient> GetPatient();

    }
}
