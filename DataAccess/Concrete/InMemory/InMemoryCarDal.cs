using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId="BMW",ColorId="#234333",ModelYear=2015,DailyPrice=250,Description="Lüks Araç"},
                new Car{Id=2,BrandId="Tofaş",ColorId="#234333",ModelYear=2015,DailyPrice=50,Description="Ucuz Günlük"},
                new Car{Id=3,BrandId="Renault",ColorId="#234333",ModelYear=2015,DailyPrice=100,Description="Aile  Aracı"},
                new Car{Id=4,BrandId="BMC",ColorId="#234333",ModelYear=2015,DailyPrice=500,Description="Ticari Kullanım"},
                new Car{Id=5,BrandId="Mercedes",ColorId="#234333",ModelYear=2015,DailyPrice=600,Description="Yolcu Aracı"}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            ////LINQ - Language Integrated Query 
            //Lambda

            Car carToDelete = _cars.SingleOrDefault(p=>p.Id==car.Id);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
            
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

        }
    }
}
