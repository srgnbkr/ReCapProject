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
        IDataResult<Car> GetAllByColorId(int id);
        IDataResult<List<Car>> GetAllByBrandId(int id);
        IDataResult<Car> GetByDailyPrice(decimal min, decimal max);
        IDataResult<Car> GetByModelYear(int year);
        IDataResult<List<CarDetailDto>> GetCarDetailDetails();

    }
}
