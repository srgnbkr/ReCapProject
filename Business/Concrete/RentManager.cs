using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidaiton;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentManager:IRentalService
    {
        IRentalDal _rentalDal;
        public RentManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        [CacheRemoveAspect("IRentalService.Get")]
        [ValidationAspect(typeof(RentValidator))]
        public IResult Add(Rental rental)
        {
            var result = BusinessRules.Run(IsRentable(rental.CarId));

            if (result != null)
            {
                return new ErrorResult();
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.CarRental);

            
        }
            





                    

        

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.CarRentDeleletd);
        }

        public IDataResult<List<Rental>> GetAllRentCars()
        {
            if (DateTime.Now.Hour==5)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarRentListed);        
        }

        public IDataResult<Rental> GetByRentDate(DateTime min, DateTime max)
        {
            if (DateTime.Now.Hour==5)
            {
                return new ErrorDataResult<Rental>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(p=>p.RentDate<=min && p.RentDate <= max),Messages.CarRentTimeListed);
        }

        public IDataResult<List<RentCarDetailDto>> GetCarDetail()
        {
            return new SuccessDataResult<List<RentCarDetailDto>>(_rentalDal.GetAllRentDetails(), Messages.CarsListed);
        }
        [ValidationAspect(typeof(RentValidator))]
        public IResult IsRentable(int carId)
        {
            var result = _rentalDal.GetAll(p => p.CarId == carId && (p.ReturnDate == null || p.ReturnDate > DateTime.Now.Date)).Any();

            if (result)
            {
                return new ErrorResult(Messages.CarDontRental);
            }
            return new SuccessResult();

        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Uptade(rental);
            return new SuccessResult(Messages.CarRentUptated);
        }
    }
}
