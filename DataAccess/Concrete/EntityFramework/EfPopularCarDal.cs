using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfPopularCarDal : EfEntityRepositoryBase<PopularCar, RentACarContext>, IPopularCarDal
    {
        public List<PopularCarDto> GetPopularCar()
        {

            using (RentACarContext context = new RentACarContext())
            {
                var result = from p in context.PopularCars
                             join c in context.Cars on p.CarId equals c.Id
                             join brand in context.Brands on c.BrandId equals brand.Id

                
                select new PopularCarDto
                             {
                                 CarName = c.Name,
                                 DailyPrice = c.DailyPrice,
                                 BrandId = c.BrandId,
                                 BrandName = brand.Name                  
                             };

                return result.ToList();

            }
        }

    }
}
