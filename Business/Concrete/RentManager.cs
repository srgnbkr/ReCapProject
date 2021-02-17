using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
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

        public IResult Add(Rental rental)
        {

            var result = _rentalDal.GetAll(p => p.CarId == rental.CarId && p.RentDate<p.ReturnDate && p.ReturnDate==null);
            if (result.Count>0)
            {
                return new ErrorResult(Messages.CarDontRental);
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
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<List<Rental>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(), Messages.CarRentListed);        
        }

        public IDataResult<Rental> GetByRentDate(DateTime min, DateTime max)
        {
            if (DateTime.Now.Hour==23)
            {
                return new ErrorDataResult<Rental>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<Rental>(_rentalDal.Get(p=>p.RentDate<=min && p.RentDate <= max),Messages.CarRentTimeListed);
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Uptade(rental);
            return new SuccessResult(Messages.CarRentUptated);
        }
    }
}
