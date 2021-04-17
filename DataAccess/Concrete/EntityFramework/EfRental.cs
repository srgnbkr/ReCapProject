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
    public class EfRental : EfEntityRepositoryBase<Rental,ECarTradeContext>,IRentalDal
    {
        public List<RentCarDetailDto> GetAllRentDetails()
        {
            using (ECarTradeContext context = new ECarTradeContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                             on r.CarId equals c.CarId
                             join cus in context.Customers
                             on r.CustomerId equals cus.CustomerId
                             join us in context.Users
                             on cus.UserId equals us.UserId

                             select new RentCarDetailDto
                             {
                                 RentId = r.RentId,
                                 CarName = c.CarName,
                                 FirstName = us.FirstName,
                                 LastName = us.LastName,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                
                                 




                             };

                return result.ToList();









            }
        }

       
        

    }
}
