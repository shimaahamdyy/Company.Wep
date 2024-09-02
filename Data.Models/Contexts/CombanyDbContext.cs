using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entites;
using Microsoft.EntityFrameworkCore;

namespace Company.Data.Contexts
{
	public class CombanyDbContext : DbContext
	{
		public CombanyDbContext(DbContextOptions <CombanyDbContext>  options) : base(options) 
			{
		
		    }

		//protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		//{
		//	optionsBuilder.UseSqlServer("server=.; database=CompanyMVCG01; trusted_connections =true; ");
		//}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
			base.OnModelCreating(modelBuilder);
		}
		public DbSet<Employee>employees { get; set; }
		public DbSet<Department> departments { get; set; }


	}
}
