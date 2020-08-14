using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaNexosBLL;
using PruebaNexosServices.Models;

namespace PruebaNexos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        [HttpGet("Buscar")]
        public IActionResult Get()
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosPatientOperations().GetPatient());
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosPatientOperations().GetPatient(id));
        }

        [HttpDelete("Eliminar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosPatientOperations().DeletePatient(id));
        }

        [HttpPost("CrearPaciente")]
        public IActionResult CreatePatient(Patient patient)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosPatientOperations().CreatePatient(patient));
        }

        [HttpPut("ActualizarPaciente")]
        public IActionResult UpdatePatient(Patient patient)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosPatientOperations().UpdatePatient(patient));
        }
    }
}
