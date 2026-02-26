using Infrastructure;
using Microsoft.EntityFrameworkCore;
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
        //limit get all 
        public async Task<List<Patient>> GetAllPatientAsync()
        {
            return await _context.Patient.ToListAsync();
        }

        public async Task<Patient?> GetPatientByIdAsync(long id)
        {
            return await _context.Patient.FindAsync(id);
        }
    }
}