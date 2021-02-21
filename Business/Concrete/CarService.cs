using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    
    public class CarService : ICarService
    {
        private ICarDal _iCarDal;
        public CarService(ICarDal iCarDal)
        {
            _iCarDal = iCarDal;
        }
        public Car Add(Car car)
        {
            return _iCarDal.Add(car);
        }

        public void Delete(int id)
        {
            _iCarDal.Delete(id);
        }

        public List<Car> GetAll()
        {
            return _iCarDal.GetAll();
        }

        public Car GetById(int Id)
        {
            return _iCarDal.GetById(Id);
        }

        public Car Update(Car car)
        {
            return _iCarDal.Update(car);
        }
    }
}
