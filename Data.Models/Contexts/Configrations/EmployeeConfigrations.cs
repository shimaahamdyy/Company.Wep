﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Company.Data.Contexts.Configrations
{
	public class EmployeeConfigrations:IEntityTypeConfiguration<Employee>
	{
		public void Configure(EntityTypeBuilder<Employee>builder)
		{
			builder.Property(x => x.Name).IsRequired(true);
		}
	}
}
