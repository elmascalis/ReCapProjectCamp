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
			//CarTest();
			//colorTest();
			CarManager carManager = new CarManager(new EfCarDal());
			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine(car.Description);
			}
		}

		private static void colorTest()
		{
			ColorManager colorManager = new ColorManager(new EfColorDal());
			foreach (var color in colorManager.GetColorDetails())
			{
				Console.WriteLine(color.Name);
			}
		}

		private static void CarTest()
		{
			CarManager carManager = new CarManager(new EfCarDal());

			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine("Adı:" + car.Description + car.Id + car.ModelYear + car.DailyPrice + car.ColorId + car.BrandId);
			}
			carManager.Add(new Car { BrandId = 4, ColorId = 1, DailyPrice = 0, Description = "H", ModelYear = "2021" });

			carManager.GetAll();
			Console.WriteLine("marka ıd 2 olan ürün adı:" + carManager.GetCarsByBrandId(4));

			carManager.GetCarsByColorId(3);
		}
	}
}
