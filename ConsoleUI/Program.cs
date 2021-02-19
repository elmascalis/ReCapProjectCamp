using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new EfCarDal());

			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine("Adı:" + car.Description + car.Id + car.ModelYear + car.DailyPrice + car.ColorId + car.BrandId);
			}
			carManager.Add(new Car { BrandId = 4, ColorId = 1, DailyPrice = 0, Description = "H", ModelYear = "2021" });

			carManager.GetAll();
			carManager.GetCarsByBrandId(2);
			
			carManager.GetCarsByColorId(3);

			
				
			

		}
	}
}
