using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{

	//generic constraint kısıt,class referans tip olabilir.(>where T:class) IEntity olabilir veya implement eden nesne olabilir.new() newlenebilir olmalı Ientity newlenemez interface.
	public interface IEntityRepository<T>where T:class,IEntity,new()
	{
		//CRUID opersaypnlarını expression delegesi yani predicate ile verildi.
		List<T> GetAll(Expression<Func<T,bool>>filter=null);
		T Get(Expression<Func<T,bool>>filter);
		void Add(T entity);
		void Update(T entity);
		void Delete(T entity);
		
	}
}
