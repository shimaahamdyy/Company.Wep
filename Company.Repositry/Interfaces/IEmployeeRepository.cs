using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entites;

namespace Company.Repositry.Interfaces
{
	public interface IEmployeeRepository:IGenericRepositry<Employee>
	{
		Employee GetEmployeeByName(string Name);
		IEnumerable<Employee> GetEmployeesByAddress(string address);
	}
}
