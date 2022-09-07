using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
<<<<<<< HEAD
        List<Car> GetCarsByBrandId(int id);
        List<Car> GetCarsByColorId(int id);
        List<CarDetailDto> GetCarDetails();
=======
>>>>>>> 8e45ee2078170a9eeab8cc9ee6b39e2873e153bf
        Car GetById(int id);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}
