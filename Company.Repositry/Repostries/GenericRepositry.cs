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
	public class GenericRepositry<T> : IGenericRepositry<T> where T : BaseEntity
	{
		private readonly CombanyDbContext _context;

		public GenericRepositry(CombanyDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
		=> _context.Set<T>().Add(entity);

		public void Delete(T entity)
		=> _context.Remove(entity);

		public IEnumerable<T> GetAll()
		=> _context.Set<T>().ToList();

		public T GetById(int id)
		=> _context.Set<T>().Find(id);

		public void Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
