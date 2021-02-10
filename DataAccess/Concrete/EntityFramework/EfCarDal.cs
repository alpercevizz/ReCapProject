using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        // public void Add(Car entity)
        // {
        //     using (CarRentalContext context = new CarRentalContext())
        //     {
        //         var addedEntity = context.Entry(entity);
        //         addedEntity.State = EntityState.Added;
        //         context.SaveChanges();
        //     }
        // }

        // public void Delete(Car entity)
        // {
        //     using (CarRentalContext context = new CarRentalContext())
        //     {
        //         var deletedEntity = context.Entry(entity);
        //         deletedEntity.State = EntityState.Deleted;
        //         context.SaveChanges();
        //     }
        // }

        //public void Update(Car entity)
        //{
        //     using (CarRentalContext context = new CarRentalContext())
        //     {
        //         var updatedEntity = context.Entry(entity);
        //         updatedEntity.State = EntityState.Modified;
        //         context.SaveChanges();
        //     }
        //}

        // public Car Get(Expression<Func<Car, bool>> filter)
        // {
        //     using (CarRentalContext context = new CarRentalContext())
        //     {
        //         return context.Set<Car>().SingleOrDefault(filter);
        //     }
        // }

        // public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        // {
        //     using (CarRentalContext context = new CarRentalContext())
        //     {
        //         return filter == null 
        //             ? context.Set<Car>().ToList() 
        //             : context.Set<Car>().Where(filter).ToList();
        //     }
        // }
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from c in context.Cars
                             join co in context.Colors
                             on c.ColorId equals co.ColorId
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             select new CarDetailDto {

                                BrandName = b.BrandName,
                                ColorName = co.ColorName,
                                DailyPrice = c.DailyPrice,
                                Descriptions = c.Description,
                                ModelYear = c.ModelYear
                             
                             };

                return result.ToList();
            }
        }
    }
}
