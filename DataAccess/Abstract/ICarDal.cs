using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
<<<<<<< HEAD
        List<CarDetailDto> GetCarDetails();
=======
        List<Car> GetAll();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        Car GetById(int id);
>>>>>>> 8e45ee2078170a9eeab8cc9ee6b39e2873e153bf
    }
}
