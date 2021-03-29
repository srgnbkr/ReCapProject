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
using System.Linq;
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
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId), Messages.CarsListed);
        }

        public IDataResult<List<CarDetailDto>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().Where(p=>p.ColorId==id).ToList());
        }

        public IDataResult<List<CarDetailDto>> GetAllCarDetailsByFilter(int brandId, int colorId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails()
                .Where(x => x.BrandId == brandId && x.ColorId == colorId).ToList());
        }

        public IDataResult<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.DailyPrice >= min && p.DailyPrice <= max));
        }
        
        public IDataResult<Car> GetByModelYear(int year)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.ModelYear == year),Messages.CarsListed);
        }
        
        public IDataResult<List<CarDetailDto>> GetCarDetailDetails()
        {
            if (DateTime.Now.Hour==5)
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

        IDataResult<List<CarDetailDto>> ICarService.GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails().Where(p => p.BrandId == brandId).ToList());
        }
    }
}
