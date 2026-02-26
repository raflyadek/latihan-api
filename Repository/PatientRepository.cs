using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Repository
{
    public class PatientRepository : IPatientRepository
    {
        public readonly AppDbContext _context;
        public PatientRepository(AppDbContext context)
        {
            _context = context;
        }
        //TODO: limit get all 
        public async Task<List<Patient>> GetAllPatientAsync()
        {
            return await _context.Patient.OrderBy(p => p.PID).ToListAsync();
        }

        public async Task<Patient?> GetPatientByIdAsync(long id)
        {
            return await _context.Patient.FindAsync(id);
        }
    }
}