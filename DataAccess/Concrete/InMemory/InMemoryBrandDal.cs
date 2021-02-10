using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryBrandDal : IBrandDal
    public class InMemoryBrandDal
    {
        //List<Brand> _brands;

        //public InMemoryBrandDal()
        //{
        //    _brands = new List<Brand>
        //    {
        //        new Brand{BrandId=1, BrandName="Toyota"},
        //        new Brand{BrandId=2, BrandName="Seat"},
        //        new Brand{BrandId=3, BrandName="Renault"},
        //        new Brand{BrandId=4, BrandName="Honda"}
        //    };
        //}
        //public void Add(Brand brand)
        //{
        //    _brands.Add(brand);
        //}

        //public void Delete(Brand brand)
        //{
        //    Brand brandToDelete = null;
        //    brandToDelete = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
        //}

        //public Brand Get(Expression<Func<Brand, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        //{
        //    return _brands;
        //}

        //public void Update(Brand brand)
        //{
        //    Brand brandToUpdate = _brands.SingleOrDefault(b => b.BrandId == brand.BrandId);
        //    brandToUpdate.BrandId = brand.BrandId;
        //    brandToUpdate.BrandName = brand.BrandName;
        //}
    }
}
