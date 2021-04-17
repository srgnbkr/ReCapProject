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
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ECarTradeContext>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetail()
        {
            using (ECarTradeContext context = new ECarTradeContext())
            {
                var result = from cs in context.Customers
                             join ur in context.Users
                             on cs.UserId equals ur.UserId
                             select new CustomerDetailDto
                             {
                                 FirstName = ur.FirstName,
                                 LastName = ur.LastName,
                                 CompanyName = cs.CompanyName,
                                 Status = ur.Status ? "Aktif":"Pasif"
                                 


                             };
                
                return result.ToList();
            }
        }
    }
}
