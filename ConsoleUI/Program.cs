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

            CarTest();
            Console.WriteLine("*******************************");
            BrandTest();
            

            
           

        }
        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetailDetails())
            {
                Console.WriteLine("Aracın Markası: "+car.BrandName+" Renk: "+car.ColorName+" Günlük Fiyatı: "+car.DailyPrice+" TL");
            }
        }
        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }
        
        
    }
}
