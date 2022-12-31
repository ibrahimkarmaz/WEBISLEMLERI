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
		[HttpGet("{id}")]
		public IActionResult EmployeeGet(int id)
		{
			using var _context = new Context();
			var employee = _context.Employees.Find(id);
			if (employee==null)
			{
				return NotFound();
			}
			else
			{
				return Ok(employee);
			}
		}

		[HttpDelete("{id}")]
		public IActionResult EmployeeDelete(int id)
		{
			using var _context = new Context();
			var employee = _context.Employees.Find(id);
			if (employee==null)
			{
				return NotFound();
			}
			else
			{
				_context.Remove(employee);
				_context.SaveChanges();
				return Ok();
			}
		}


		[HttpPut]
		public IActionResult EmployeeUpdate(Employee employee)
		{
			using var _context = new Context();
			var employee2 = _context.Employees.Find(employee.ID);
			if (employee2 == null)
			{
				return NotFound();
			}
			else
			{
				employee2.Name = employee.Name;
				_context.Update(employee2);
				_context.SaveChanges();
				return Ok();
			}
		}

	}
}
