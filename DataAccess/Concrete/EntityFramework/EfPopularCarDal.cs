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
                             select new PopularCarDto
                             {
                                 CarName = c.Name
                             };
                return result.ToList();

            }
        }

    }
}
