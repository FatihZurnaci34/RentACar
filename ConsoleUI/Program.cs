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
            //CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            //customerManager.Add(new Customer { UserId=2});

            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            rentalManager.Add(new Rental { CarId = 2, CustomerId = 1, RentDate = DateTime.Now });

            /*UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            {          
                FirstName="Kaan",
                LastName="deneme",
                Email="deneme",
                Password="123456"
            });
            */

            //carManager.Delete(new Car { Id = 6 });
            //carManager.Update(new Car { Id = 7, BrandId = 1, ColorId = 1, DailyPrice = 2550, Name = "BMW", ModelYear = 2022, Description = "3.20" });

            //carManager.GetById(6);
            //TestCarDetails();
        }

    }
}
