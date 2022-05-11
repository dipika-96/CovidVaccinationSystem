using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidVaccinationProject.Model
{
    public class PatientsRepository : IPatientsRepository
    {
        private readonly AppDbContext _context;
        public PatientsRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Patients> Add(Patients patients)
        {
            await _context.Patients.AddAsync(patients);
            _context.SaveChanges();
            return patients;
        }

        public async Task<IEnumerable<Patients>> GetAllPatients()
        {
            return await _context.Patients.ToListAsync();
        }

        public async Task<Patients> GetPatients(int id)
        {
            return await _context.Patients.FindAsync(id);
        }

        public async Task<Patients> Update(Patients patients)
        {
            var data = _context.Patients.Update(patients);
            data.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            await _context.SaveChangesAsync();
            return patients;
        }
    }
}
