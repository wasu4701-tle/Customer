using Projecttitle.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projecttitle.Models;

namespace Projecttitle.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _service;

        public CustomerController(CustomerService service)
        {
            _service = service;
 
        }

        [HttpGet("GetQueueAll")] // ใช้สำหรับ HTTP GET แบบไม่มีพารามิเตอร์
        public async Task<ActionResult<Patient[]>> GetPatients()
        {
            var Patient = await _service.GetPatientAsync(); // เรียก service เพื่อดึงข้อมูล
            return Ok(Patient); // ส่งข้อมูลกลับแบบ 200 OK
        }

        [HttpGet("GetQueueById/{id}")]
public async Task<ActionResult<Patient>> GetPatientById(string id)
{
    var patient = await _service.GetPatientByIdAsync(id);

    if (patient == null)
    {
        return NotFound(new
        {
            message = "ไม่พบข้อมูล Patient",
            id = id
        });
    }

    return Ok(patient);
}







    }
}