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
                             join b in context.Brands
                             on cr.BrandId equals b.BrandId
                             join co in context.Colors
                             on cr.ColorId equals co.ColorId
                             select new CarDetailDto
                             {
                                 CarId = cr.CarId,
                                 BrandId = b.BrandId,
                                 ColorId = co.ColorId,
                                 BrandName = b.BrandName,
                                 CarName = cr.CarName,
                                 ColorName = co.ColorName,
                                 DailyPrice = cr.DailyPrice,
                                 ModelYear = cr.ModelYear,
                                 Descriptions = cr.Descriptions,
                                 ImagePath = context.CarImages.Where(x => x.CarId == cr.CarId).FirstOrDefault().ImagePath

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();




            }
        }

       
    }
}
