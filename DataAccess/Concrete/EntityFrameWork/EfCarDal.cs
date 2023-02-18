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
        public List<Car> GetById(Expression<Func<Car, bool>> filter, int id)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailsDto> GetCarDetails()
        {
            using (CarsContext context = new CarsContext()) 
            {
                var result = from c in context.Cars
                             join j in context.Colors on c.ColorId equals j.ColorId
                             join b in context.Brandss on c.BrandId equals b.BrandId
                             select new CarDetailsDto { CarName = c.Description, BrandName = b.BrandName, ColorName = j.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }

        public List<CarDetailsDto> GetCars()
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from c in context.Cars
                             join j in context.Colors on c.ColorId equals j.ColorId
                             join b in context.Brandss on c.BrandId equals b.BrandId
                             select new CarDetailsDto { CarName = c.Description, BrandName = b.BrandName, ColorName = j.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }

        public List<CarDetailsDto> GetCarsByBrandId(Expression<Func<Car, bool>> filter, int brandId)
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from c in context.Cars
                             join j in context.Colors on c.ColorId equals j.ColorId
                             join b in context.Brandss on c.BrandId equals b.BrandId
                             where b.BrandId == brandId
                             select new CarDetailsDto { CarsId = c.CarId, BrandName = b.BrandName, ColorName = j.ColorName, Description = c.Description, DailyPrice = c.DailyPrice, ModelYear = c.ModelYear, BrandId = c.BrandId, ColorId = c.ColorId };
                return result.ToList();
            }
        }
        
        public List<CarDetailsDto> GetCarsByColorId(Expression<Func<Car, bool>> filter, int colorId)
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from c in context.Cars
                             join j in context.Colors on c.ColorId equals j.ColorId
                             join b in context.Brandss on c.BrandId equals b.BrandId
                             where c.ColorId == colorId
                             select new CarDetailsDto { CarsId = c.CarId, BrandName = b.BrandName, ColorName = j.ColorName, Description = c.Description, DailyPrice = c.DailyPrice, ModelYear = c.ModelYear, BrandId = c.BrandId, ColorId = c.ColorId };
                return result.ToList();
            }
        }
    }
}
