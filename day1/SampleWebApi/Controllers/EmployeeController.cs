using Microsoft.AspNetCore.Mvc;
using SampleWebApi.Interfaces;
using SampleWebApi.Models;

namespace SampleWebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }

        [HttpGet(Name = "GetEmployee")]
        public IEnumerable<Employee> Get()
        {
            return this.service.GetAll();
        }

        [HttpPost(Name = "Create")]
        public IActionResult Create(Employee employee)
        {
            this.service.Add(employee);
            return Ok();
        }

        [HttpPost(Name = "Update")]
        public IActionResult Update(string name, string grade)
        {
            this.service.Update(name, grade);
            return Ok();
        }

        [HttpPost(Name = "Delete")]
        public IActionResult Delete(string name)
        {
            this.service.Delete(name);
            return Ok();
        }
    }
}
