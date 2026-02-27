using dto;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.IdentityModel.Tokens;
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

        public async Task<IEnumerable<Patient?>> GetPatientFilterAsync(PatientSearchRequest filter)
        {
            var query = _context.Patient.AsQueryable();

            if (filter == null)
            {
                return await query.ToListAsync();
            }

            if (!string.IsNullOrWhiteSpace(filter.PNAME))
            {
                query = query.Where(p => p.PNAME.Contains(filter.PNAME));
            }
            if (filter.PDOB.HasValue)
            {
                query = query.Where(p => p.PDOB == filter.PDOB.Value);
            }
            if (!string.IsNullOrWhiteSpace(filter.PRN))
            {
                query = query.Where(p => p.PRN.Contains(filter.PRN));
            }
            return await query.ToListAsync();
        }
    }
}