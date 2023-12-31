using ApiForCompany.DataAcsess;
using ApiForCompany.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiForCompany.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly AppDbContext _context;
        public WeatherForecastController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        [HttpGet]
        public IActionResult GetEmployeeWithCompany()
        {
            List<Employee>? result=_context.Employee.Include(x => x.Company).ToList();
            return Ok(result);
        }
        [HttpGet]
        public IActionResult GetStaffEmployee()
        {
            var bir=_context.Employee.Include(x=>x.Staffs)
                .ThenInclude(x => x.Staff).ToList();
            return Ok(bir);
        }
    }
}
