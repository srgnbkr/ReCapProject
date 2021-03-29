using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ECarTradeContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails(Expression<Func<CarDetailDto, bool>> filter = null)
        {
            using (ECarTradeContext context = new ECarTradeContext())
            {
                var result = from cr in context.Cars
                             join c in context.Colors
                             on cr.ColorId equals c.ColorId
                             join b in context.Brands
                             on cr.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 CarId = cr.CarId,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 ColorId = c.ColorId,
                                 CarName = cr.CarName,
                                 ColorName = c.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 ModelYear = cr.ModelYear





                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

       
    }
}
