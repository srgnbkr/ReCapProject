using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            















        }
        private static void UsersTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAllUsers();

            if (result.Success==true)
            {
                Console.WriteLine(result.Message);
                foreach (var user in result.Data)
                {
                    Console.WriteLine(user.FirstName+" "+user.LastName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void RentTest()
        {
            RentManager rentManager = new RentManager(new EfRental());
            var result = rentManager.Add(new Rental {CarId=6,CustomerId=2003,RentDate=new DateTime(2021,02,13),ReturnDate=new DateTime(2021,02,17) });
            if (result.Success==true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAllCustomers();
            if (result.Success==true)
            {
                
                Console.WriteLine(result.Message);
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer.CompanyName);
                }
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        
        

        
            
        



    }




}


