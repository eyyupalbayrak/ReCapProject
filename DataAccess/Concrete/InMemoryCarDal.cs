using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
              new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = 2015, DailyPrice = 130000, Description = "Kapısı yoktu"},
              new Car{Id = 2, BrandId = 2, ColorId = 2, ModelYear = 2006, DailyPrice = 100000, Description = "İki araba birleşimi vah vah"},
              new Car{Id = 3, BrandId = 3, ColorId = 3, ModelYear = 2003, DailyPrice = 500000, Description = "Kaput değişimi"},
              new Car{Id = 4, BrandId = 4, ColorId = 4, ModelYear = 2000, DailyPrice = 700000, Description = "Boyamışlar"},
              new Car{Id = 5, BrandId = 3, ColorId = 3, ModelYear = 2015, DailyPrice = 78252000, Description = "Sıfır ayarında AMA PERT"},
              new Car{Id = 6, BrandId = 1, ColorId = 3, ModelYear = 2025, DailyPrice = 850500, Description = "Boyamışlar tavanı"},
            };
        }

        public Car Add(Car car)
        {
             _cars.Add(car);
            return car;
        }

        public void Delete(int id)
        {
            var car = GetById(id);
            _cars.Remove(car);
        }

       

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetById(int id)
        {
            return _cars.Find(p=>p.Id==id );
        }

        public Car Update(Car car)
        {
            Delete(car.Id);
            return Add(car);
        }

    }
}
