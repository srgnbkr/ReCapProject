using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> GetAllByColorId(int id);
        IDataResult<List<CarDetailDto>> GetAllByBrandId(int brandId);
        IDataResult<Car> GetByDailyPrice(decimal min, decimal max);
        IDataResult<Car> GetByModelYear(int year);
        IDataResult<List<CarDetailDto>> GetCarDetailDetails();
        IDataResult<List<CarDetailDto>> GetAllCarDetailsByFilter(int brandId, int colorId);
        IDataResult<List<CarDetailDto>> GetCarByCarId(int carId);

    }
}
