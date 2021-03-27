﻿using Business.Abstract;
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
        
        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p=>p.BrandId==id),Messages.CarsListed);
        }
        
        public IDataResult<Car> GetAllByColorId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.ColorId == id), Messages.CarsListed);
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
    }
}
