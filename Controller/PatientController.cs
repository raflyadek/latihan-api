using Microsoft.AspNetCore.Mvc;
using Services;

namespace Controller
{
[ApiController]
[Route("patient")]
    public class PatientController : ControllerBase
    {
        public readonly IPatientService _service;
        public PatientController(IPatientService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var patient = await _service.GetAllAsync();
            return Ok(patient);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute]int id)
        {
            Console.WriteLine($"id: {id}");
            var patient = await _service.GetByIdAsync(id);
            return Ok(patient);
        }
    }
}