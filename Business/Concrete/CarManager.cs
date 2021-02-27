using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;


namespace Business.Concrete
{
	public class CarManager : ICarService
	{
		//Constractor Injection yaptım.Entity framework nhibernat olur o sebeple..
		ICarDal _carDal;
        //ben kategori car manager olarak veri erişim katmamına baglıyım interfaace referans üzerinden bağımlıyım.
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
			if (car.Description.Length > 2 && car.DailyPrice > 0)
			{
				Console.WriteLine("Araba eklendi....Algoritmik");
				_carDal.Add(car);
			}
			else
			{
				Console.WriteLine("Araba eklenemedi. Araba ismi minimum 2 karakter olmalıdır ve Araba günlük fiyatı 0'dan büyük olmalıdır.");
			}
		}
		public void Update(Car car)
		{
			throw new NotImplementedException();
		}

		public void Delete(Car car)
		{
			throw new NotImplementedException();
		}

		//public List<CarDetailDto> GetCarDetails()
		//{
		//	throw new NotImplementedException();
		//}

		public Car GetCarsByBrandId(int Id)
		{
			throw new NotImplementedException();
		}

		public Car GetCarsByColorId(int colorId)
		{
			throw new NotImplementedException();
		}

		public Car GetById(int carId)
		{
			return _carDal.Get(c=>c.Id==carId);
		}
	}
}
