using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.DailyPrice > 0)
            {
                _carDal.Add(car);
                Console.WriteLine("Araba başarıyla eklendi.");
            }

            else
            {
                Console.WriteLine("Lütfen günlük fiyatı 0'dan büyük giriniz ! Girdiğiniz değer : " + car.DailyPrice);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
            Console.WriteLine("Araba başarıyla silindi. ");
        }

        public void Update(Car car)
        {
            if(car.DailyPrice > 0 )
            {
                _carDal.Update(car);
                Console.WriteLine("Arabanın özellikleri başarıyla güncellendi.");
            } 

            else
            {
                Console.WriteLine("Lütfen günlük fiyatı 0'dan büyük giriniz ! Girdiğiniz değer: " + car.DailyPrice);
            }
            
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();   
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(c=>c.BrandId == id);
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(co => co.ColorId == id);
        }

        public List<Car> GetByDailyPrice(decimal min, decimal max)
        {
            return _carDal.GetAll(dp => dp.DailyPrice >= min && dp.DailyPrice <= max);
        }

        public List<Car> GetByModelYear(string year)
        {
            return _carDal.GetAll(my => my.ModelYear.Contains(year) == true);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
