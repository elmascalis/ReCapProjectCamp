﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public List<Car> GetAll()
		{
			//iş kodları
			//yetkisi var mı?
			return _carDal.GetAll();
		}

		public void Add(Car car)
		{
			_carDal.Add(car);
		}
	}
}
