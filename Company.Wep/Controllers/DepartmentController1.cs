using Company.Repositry.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company.Wep.Controllers
{
	public class DepartmentController1 : Controller
	{
		private readonly IDepartmentRepository _departmentRepository;

		public DepartmentController1(IDepartmentRepository departmentRepository)
        {
			_departmentRepository = departmentRepository;
		}
        public IActionResult Index()
		{
			var departments= _departmentRepository.GetAll();

			return View();
		}
	}
}
