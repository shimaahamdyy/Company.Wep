﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
 
namespace Company.Data.Contexts.Configrations
{
	public class DepartmentConfigrations : IEntityTypeConfiguration<Department>
	{	   
		
			public void Configure(EntityTypeBuilder<Department> builder)
		{
			builder.Property(x => x.Id).UseIdentityColumn(10,10);
			builder.HasIndex(x => x.Name).IsUnique();
		}

		
	}
	
	
	
}
