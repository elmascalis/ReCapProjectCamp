using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
	public class EfColorDal : EfEntityRepositoryBase<Color, NorthwindContext>, IColorDal
	{
		public List<ColorDetailDto> GetColorDetails()
		{
			using (NorthwindContext northwindContext = new NorthwindContext())
			{
				var result = from co in northwindContext.Colors
							 join c in northwindContext.Cars
							 on co.Id equals c.ColorId
							 select new ColorDetailDto
							 {
								ColorId=c.ColorId,Description=c.Description,
							 };
				return result.ToList();
			}
		
		}
	}
}
