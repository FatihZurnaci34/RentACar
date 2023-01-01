using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            var result = _rentalDal.Get(r => r.CarId == rental.CarId && r.ReturnDate == null);
            if (result==null)
            {
                _rentalDal.Add(rental);
                return new SuccessResult();
            }
            
            return new ErrorResult("Araç Kiralanmış");
        }


        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult();
        }


        public IResult Deliver(Rental rental)
        {
            IResult result = BusinessRules.Run(CheckIfDeliverExists(rental.Id));
            if (result !=null)
            {
                return null;
            }
            _rentalDal.Deliver(rental);
            return new SuccessResult("Araç Teslim Edildi.");
        }

        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(p => p.Id == id));
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult();
        }

        private IResult CheckIfDeliverExists(int id)
        {
            var result = _rentalDal.Get(x => x.Id == id);
            if (result.ReturnDate!=null)
            {
                return new ErrorResult();
            }
            return new SuccessResult();

        }   
    }
}
