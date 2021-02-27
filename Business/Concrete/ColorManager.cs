using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class ColorManager : IColorService
	{
		//veri erişimine bağlı,bunuda constractor ınjection
		IColorDal _colorDal;
		//generet constractor
		public ColorManager(IColorDal colorDal)
		{
			_colorDal = colorDal;
		}

		public List<Color> GetAll()
		{
			return _colorDal.GetAll();
		}

		public Color GetByColorId(int colorId)
		{
			return _colorDal.Get(c => c.Id == colorId);
		}

		public List<ColorDetailDto> GetColorDetails()
		{
			return _colorDal.GetColorDetails();
		}
	}
}
