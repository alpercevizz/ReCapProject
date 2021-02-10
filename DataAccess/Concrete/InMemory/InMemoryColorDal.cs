using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    //public class InMemoryColorDal : IColorDal
    public class InMemoryColorDal
    {
       // List<Color> _colors;
       // public InMemoryColorDal()
       // {
       //     _colors = new List<Color>
       //     {
       //         new Color{ColorId=1, ColorName="Beyaz"},
       //         new Color{ColorId=2, ColorName="Siyah"}
       //     };
       // }
       // public void Add(Color color)
       // {
       //     _colors.Add(color);
       // }

       // public void Delete(Color color)
       // {
       //     Color colorToDelete = null;
       //     colorToDelete = _colors.SingleOrDefault(co=>co.ColorId==color.ColorId);
       // }

       // public Color Get(Expression<Func<Color, bool>> filter)
       // {
       //     throw new NotImplementedException();
       // }

       // //public List<Color> GetAll()
       // //{
       // //    return _colors;
       // //}

       //public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
       //{
       //     return _colors;
       // }

       // public List<Color> GetById(int id)
       // {
       //     return _colors.Where(co => co.ColorId == id).ToList();
       // }

       // public void Update(Color color)
       // {
       //     Color colorToUpdate = _colors.SingleOrDefault(co => co.ColorId == color.ColorId);
       //     colorToUpdate.ColorId = color.ColorId;
       //     colorToUpdate.ColorName = color.ColorName;
       // }
    }
}
