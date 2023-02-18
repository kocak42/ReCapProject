using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.CarDTOs;
using Entities.Concrete;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarsContext>, IColorDal
    {
        //public List<CarDetailsDto> GetCarsByColorId(int id)
        //{
        //    using (CarsContext context = new CarsContext())
        //    {
        //        //var result = /*from c in context.Cars*/
        //        //             join j in context.Colors
        //        //             on c.BrandId equals j.Id
        //        //             where j.ColorId == id
        //        //             select new CarDetailsDto { ColorName = j.ColorName, Description = c.Description };
        //        //return result.ToList();
        //    }
        //}
    }
}
