using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if(car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.AddedCar);
            }

            else
            {
                return new ErrorResult(Messages.FailedCarAddOrUpdate);
            }
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedCar);
        }

        public IResult Update(Car car)
        {
            if(car.DailyPrice > 0 )
            {
                _carDal.Update(car);
                return new SuccessResult(Messages.UpdatedCar);
            } 

            else
            {
                return new ErrorResult(Messages.FailedCarAddOrUpdate);
            }
            
        }
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());   
        }

        //public IDataResult <Car> GetAllByBrandId(int id)
        //{
        //    return _carDal.GetAll(c=>c.BrandId == id);
        //}

        //public IDataResult<Car> GetAllByColorId(int id)
        //{
        //    return _carDal.GetAll(co => co.ColorId == id);
        //}

        //public List<Car> GetByDailyPrice(decimal min, decimal max)
        //{
        //    return _carDal.GetAll(dp => dp.DailyPrice >= min && dp.DailyPrice <= max);
        //}

        //public List<Car> GetByModelYear(string year)
        //{
        //    return _carDal.GetAll(my => my.ModelYear.Contains(year) == true);
        //}

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails(Expression<Func<Car,bool>> filter = null)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(filter));
        }

        
    }
}
