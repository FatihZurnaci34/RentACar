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
            //carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 650, Name = "Volvo", ModelYear = 2020, Description = "Kırmızı XC90 SUV" });

            //carManager.Delete(new Car { Id = 6 });
            //carManager.Update(new Car { Id = 7, BrandId = 1, ColorId = 1, DailyPrice = 2550, Name = "BMW", ModelYear = 2022, Description = "3.20" });

            carManager.GetById(6);
            TestCarDetails();
        }

        private static void TestCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("{0} / {1} / {2} / {3}", car.CarName, car.BrandName, car.ColorName, car.DailyPrice);
            }
        }

        private static void TestGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
