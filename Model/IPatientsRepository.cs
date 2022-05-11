using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccinationProject.Model
{
    public interface IPatientsRepository
    {
        Task<Patients> GetPatients(int id);
        Task<IEnumerable<Patients>> GetAllPatients();
        Task<Patients> Add(Patients patients);
        Task<Patients> Update(Patients patients);
    }
}
