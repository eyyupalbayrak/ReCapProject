using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        Car GetById(int Id);
        List<Car> GetAll();
        Car Add(Car car);
        Car Update(Car car);
        void Delete(int id);
    }
}
