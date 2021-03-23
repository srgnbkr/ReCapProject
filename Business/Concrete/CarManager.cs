using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidaiton;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager:ICarService

    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("admin")]
        [ValidationAspect(typeof(CarValidator))]
        
        public IResult Add(Car car)
        {
           
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Car>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarsListed);
        }
        [CacheAspect]
        public IDataResult<Car> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.BrandId == id),Messages.CarsListed);
        }
        [CacheAspect]
        public IDataResult<Car> GetAllByColorId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.ColorId == id), Messages.CarsListed);
        }
        [CacheAspect]
        public IDataResult<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }
        [CacheAspect]
        public IDataResult<Car> GetByModelYear(int year)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.ModelYear == year),Messages.CarsListed);
        }
        [CacheAspect]
        public IDataResult<List<CarDetailDto>> GetCarDetailDetails()
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarsListed);
        }

        public IResult Update(Car car)
        {
            _carDal.Uptade(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
