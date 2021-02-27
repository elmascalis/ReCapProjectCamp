﻿using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
	public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, ICarDal
	{
		public List<CarDetailDto> GetCarDetails()
		{
			using (NorthwindContext context = new NorthwindContext())
			{
				var result =
				from c in context.Cars
				join b in context.Brands
				on c.BrandId equals b.Id
			
				select new CarDetailDto { CarId = c.Id, CarName = c.Description, BrandName = b.Name, DailyPrice = c.DailyPrice };
				return result.ToList();
			}
		}

	}
}