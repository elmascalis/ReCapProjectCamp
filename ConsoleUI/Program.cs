using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			CarManager carManager = new CarManager(new InMemoryCarDal());

			foreach (var car in carManager.GetAll())
			{
				Console.WriteLine("Adı:" + car.Description + car.Id + car.ModelYear+ car.DailyPrice+ car.ColorId+ car.BrandId);
			}
		}
	}
}
