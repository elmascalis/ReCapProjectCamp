using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryCarDal : ICarDal
	{
		List<Car> _cars;
		//ctor constructor oluşturulması. bellekte referans aldıgı zaman çalışacak blok.
		public InMemoryCarDal()
		{	
			//oracle,sql,Mongo
			_cars = new List<Car> 
			{
				new Car{Id=1,BrandId=2,ColorId=3,DailyPrice=4,ModelYear="2021",Description="6" },
				new Car{Id=2,BrandId=3,ColorId=3,DailyPrice=40,ModelYear="2011",Description="6" },
				new Car{Id=3,BrandId=4,ColorId=3,DailyPrice=400,ModelYear="2012",Description="6" },
				new Car{Id=4,BrandId=5,ColorId=3,DailyPrice=4000,ModelYear="2020",Description="6" },
				new Car{Id=5,BrandId=6,ColorId=3,DailyPrice=40000,ModelYear="2019",Description="6" }
			};
		}
		public void Add(Car car)
		{
			_cars.Add(car);
		}

		public void Delete(Car car)
		{
	
			Car carsToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
			_cars.Remove(carsToDelete);
		}

		public List<Car> GetAll()
		{
			return _cars;
		}

		public List<Car> GetById(int Id)
		{
			return	_cars.Where(p => p.Id == Id).ToList();
		}

		public void Update(Car car)
		{
			Car carsToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
			carsToUpdate.Id = car.Id;
			carsToUpdate.ModelYear = car.ModelYear;
			carsToUpdate.ColorId = car.ColorId;
			carsToUpdate.DailyPrice = car.DailyPrice;
			carsToUpdate.BrandId = car.BrandId;
		}
	}
}
