using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryCarDal : ICarDal
    public class InMemoryCarDal
    {
        //List<Car> _cars;
        //public InMemoryCarDal()
        //{
        //    _cars = new List<Car> { 
        //        new Car{Id=1, BrandId=1, ColorId=1, ModelYear="2012", DailyPrice=350, Description="Toyota Corolla 1.4 D4D Comfort Manuel"},
        //        new Car{Id=2, BrandId=2, ColorId=1, ModelYear="2020", DailyPrice=500, Description="Seat Leon FR 1.6 Automatic"},
        //        new Car{Id=3, BrandId=3, ColorId=1, ModelYear="2020", DailyPrice=350, Description="Renault Megane 4 1.4 Icon Automatic"},
        //        new Car{Id=4, BrandId=4, ColorId=2, ModelYear="2019", DailyPrice=300, Description="Honda Civic 1.6 Automatic"}
        //    };
        //}
        //public void Add(Car car)
        //{
        //    _cars.Add(car);
        //}

        //public void Delete(Car car)
        //{
        //    Car carToDelete = null;

        //    //foreach (var c in _cars)
        //    //{
        //    //    if(car.Id== c.Id)
        //    //    {
        //    //        carToDelete = c;
        //    //    }
        //    //}

        //    carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
        //}

        //public Car Get(Expression<Func<Car, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        //{
        //    return _cars;
        //}

        //public List<Car> GetById(int id)
        //{
        //    return _cars.Where(c => c.Id == id).ToList();
        //}

        //public List<CarDetailDto> GetCarDetails()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Car car)
        //{
        //    Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
        //    carToUpdate.Id = car.Id;
        //    carToUpdate.ColorId = car.ColorId;
        //    carToUpdate.BrandId = car.BrandId;
        //    carToUpdate.DailyPrice = car.DailyPrice;
        //    carToUpdate.ModelYear = car.ModelYear;
        //    carToUpdate.Description = car.Description;
        //}
    }
}
