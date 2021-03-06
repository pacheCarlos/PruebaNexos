﻿using System;
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
    public class DoctorController : ControllerBase
    {
        [HttpGet("Buscar")]
        public IEnumerable<Doctor> Get()
        {
            return PruebaNexosOperation.GetPruebaNexosDoctorOperations().GetDoctors();
        }

        [HttpGet("Buscar/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosDoctorOperations().GetDoctor(id));
        }

        [HttpDelete("Eliminar/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosDoctorOperations().DeleteDoctor(id));
        }

        [HttpPost("CrearDoctor")]
        public IActionResult CreateDoctor(Doctor doctor)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosDoctorOperations().CreateDoctor(doctor));
        }

        [HttpPut("ActualizarDoctor")]
        public IActionResult UpdateDoctor([FromBody] Doctor doctor)
        {
            return Ok(PruebaNexosOperation.GetPruebaNexosDoctorOperations().UpdateDoctor(doctor));
        }
    }
}
