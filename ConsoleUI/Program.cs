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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandId = 5, BrandName = "Passat" });
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            carManager.Add(new Car {BrandId=5,ColorId=3,ModelYear=2018,DailyPrice=400,Descriptions="C Class" });

            foreach (var car in carManager.GetByDailyPrice(100,1000))
            {
                Console.WriteLine(car.BrandId);
            }

            

            
           

        }
    }
}
