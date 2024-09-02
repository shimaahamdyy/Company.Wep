using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Contexts;
using Company.Data.Entites;
using Company.Repositry.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Company.Repositry.Repostries
{
	public class EmployeeRepository :GenericRepositry<Employee>, IEmployeeRepository
	{
		private readonly CombanyDbContext _context;

		public EmployeeRepository(CombanyDbContext context):base(context)
		{
			_context = context;
		}

		public Employee GetEmployeeByName(string Name)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Employee> GetEmployeesByAddress(string address)
		{
			throw new NotImplementedException();
		}
	}
}