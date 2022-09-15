using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public void Deliver(Rental rental)
        {
            
                using (RentACarContext context = new RentACarContext())
                {
                Rental rentals = context.Rentals.Find(rental.Id);
                rental.ReturnDate = DateTime.Now;
                context.SaveChanges();
                }
            
        }
    }
}
