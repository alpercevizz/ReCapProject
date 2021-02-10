using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetCarDetails())
            //{
            //    Console.WriteLine(car.ModelYear + " " + " " + car.Descriptions + " " + car.DailyPrice + " TL");
            //}
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine("Araç Kiralama Sistemine Hoşgeldiniz...");
            
        }
    }
}
