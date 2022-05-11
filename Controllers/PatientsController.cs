using CovidVaccinationProject.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccinationProject.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private IPatientsRepository _repositoryPatients;
        public PatientsController(IPatientsRepository repositoryPatients)
        {
            _repositoryPatients = repositoryPatients;
        }

        [HttpGet]
        public async Task<IEnumerable<Patients>> GetAllPatients()
        {
            return await _repositoryPatients.GetAllPatients();
        }

        [HttpGet("{id}")]
        public async Task<Patients> GetPatientsById(int id)
        {
            return await _repositoryPatients.GetPatients(id);
        }
        [HttpPost]
        public async void AddPatient([FromBody] Patients patients)
        {
            await _repositoryPatients.Add(patients);
        }
        [HttpPut("{id}")]
        public async void UpdatePatient(int id, [FromBody] Patients patients)
        {
            if (_repositoryPatients.GetPatients(id) != null)
            {
                await _repositoryPatients.Update(patients);
            }
        }
    }
}
