﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Data.Entites;

namespace Company.Repositry.Interfaces
{
	public interface IGenericRepositry<T> where T : BaseEntity
	{
		T GetById(int id);
		IEnumerable<T> GetAll();
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
	}
}
