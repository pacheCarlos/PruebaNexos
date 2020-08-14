using PruebaNexosBLL.Bussiness;
using PruebaNexosServices;
using System;

namespace PruebaNexosBLL
{
    public class PruebaNexosOperation
    {
        public static IPruebaNexosDoctorServices GetPruebaNexosDoctorOperations()
        {
            return new DoctorBussiness();
        }

        public static IPruebaNexosPatientServices GetPruebaNexosPatientOperations()
        {
            return new PatientBussiness();
        }
    }
}
