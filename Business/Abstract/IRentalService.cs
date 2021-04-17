using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rental rental);
        IResult Update(Rental rental);
        IResult Delete(Rental rental);

        IDataResult<List<Rental>> GetAllRentCars();

        IDataResult<Rental> GetByRentDate(DateTime min,DateTime max);
        IDataResult<List<RentCarDetailDto>> GetCarDetail();
        IResult IsRentable(int carId);


    }
}
