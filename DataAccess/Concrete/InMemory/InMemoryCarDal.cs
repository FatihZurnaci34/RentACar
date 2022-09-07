using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1, ColorId=1,ModelYear=2020 ,DailyPrice=1000,Description="100km"  },
                new Car{Id=2,BrandId=1, ColorId=2,ModelYear=2017 ,DailyPrice=800,Description="200km"  },
                new Car{Id=3,BrandId=2, ColorId=3,ModelYear=2018 ,DailyPrice=700,Description="300km"  },
                new Car{Id=4,BrandId=2, ColorId=4,ModelYear=2015 ,DailyPrice=600,Description="400km"  },
                new Car{Id=5,BrandId=3, ColorId=5,ModelYear=1999 ,DailyPrice=500,Description="500km"  }
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _car.SingleOrDefault(p => p.Id==car.Id);
            _car.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;
        }

        public Car GetById(int id)
        {
            return _car.FirstOrDefault(p => p.Id == id);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
