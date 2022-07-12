using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.CarDTOs;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsContext>, ICarDal
    {
        public List<CarDetailsDto> GetCarDetails()
        {
            using (CarsContext context = new CarsContext()) 
            {
                var result = from c in context.Cars
                             join b in context.Brandss
                             on c.BrandId equals b.Id
                             join col in context.Colors
                             on c.ColorId equals col.Id
                             select new CarDetailsDto
                             {
                                 BrandName = b.BrandName,
                                 CarName = c.Description,
                                 ColorName = col.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
