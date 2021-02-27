using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace Business.Abstract
{
	public interface ICarService
	{
		List<Car> GetAll();
		Car GetById(int carId);
		Car GetCarsByBrandId(int Id);

		Car GetCarsByColorId(int colorId);
		void Add(Car car);
		void Update(Car car);
		void Delete(Car car);
		//List<CarDetailDto> GetCarDetails();

	}
}
