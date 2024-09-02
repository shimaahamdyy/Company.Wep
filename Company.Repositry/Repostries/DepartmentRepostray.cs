using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Contexts;
using Company.Data.Entites;
using Company.Repositry.Interfaces;

namespace Company.Repositry.Repostries
{
	public class DepartmentRepostray : GenericRepositry<Department>, IDepartmentRepository
	{
		private readonly CombanyDbContext _context;

		public DepartmentRepostray(CombanyDbContext context) : base(context)
		{
			_context = context;
		}

	}
}