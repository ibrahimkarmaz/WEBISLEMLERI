using BlogApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BlogApiDemo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DefaultController : ControllerBase
	{
		[HttpGet]
		public IActionResult EmployeeeList()
		{
			using var _context = new Context();
			var values = _context.Employees.ToList();
			return Ok(values);
		}

		[HttpPost]
		public IActionResult EmployeeeAdd(Employee employee)
		{
			using var _context = new Context();
			_context.Add(employee);
			_context.SaveChanges();
			return Ok();
		}
	}
}
