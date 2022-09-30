using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PopularCarManager : IPopularCarService
    {
        IPopularCarDal _popularCarDal;

        public PopularCarManager(IPopularCarDal popularCarDal)
        {
            _popularCarDal = popularCarDal;
        }

        public IDataResult<List<PopularCarDto>> GetAll()
        {
            return new SuccessDataResult<List<PopularCarDto>>(_popularCarDal.GetPopularCar());
        }
    }
}
