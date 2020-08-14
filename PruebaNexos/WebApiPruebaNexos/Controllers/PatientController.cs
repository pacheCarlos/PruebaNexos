using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PruebaNexosBLL;
using PruebaNexosServices.Models;

namespace WebApiPruebaNexos.Controllers
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

        [HttpGet("Eliminar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosPatientOperations().DeletePatient(id));
        }

        [HttpPost("CrearDoctor")]
        public IActionResult CreateDoctor(Patient patient)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosPatientOperations().CreatePatient(patient));
        }

        [HttpPost("ActualizarDoctor")]
        public IActionResult UpdateDoctor(Patient patient)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosPatientOperations().UpdatePatient(patient));
        }
    }
}
