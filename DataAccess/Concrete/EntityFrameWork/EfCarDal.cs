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
                var result = from car in context.Cars
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             select new CarDetailsDto
                             {
                                 CarName = brand.BrandName,
                                 CarsId = car.CarId,
                                 BrandId = brand.BrandId,
                                 ColorId = color.ColorId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 ModelName = car.ModelName,
                                 ImagePath = (from img in context.CarImages
                                              where img.CarId == car.CarId
                                              select img.ImagePath).FirstOrDefault()

                             };
                return result.ToList();
            }
        }

        public List<CarDetailsDto> GetCarDetailsByBrand(int brandId)
        {
            using (CarsContext context = new CarsContext())
            {
                var result = from car in context.Cars
                             join brand in context.Brands on car.BrandId equals brand.BrandId
                             join color in context.Colors on car.ColorId equals color.ColorId
                             where car.BrandId == brandId
                             select new CarDetailsDto
                             {
                                 CarName = brand.BrandName,
                                 CarsId = car.CarId,
                                 BrandId = brand.BrandId,
                                 ColorId = color.ColorId,
                                 BrandName = brand.BrandName,
                                 ColorName = color.ColorName,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description,
                                 ModelName = car.ModelName,
                                 ImagePath = (from img in context.CarImages
                                              where img.CarId == car.CarId
                                              select img.ImagePath).FirstOrDefault()

                             };
                return result.ToList();
            }
        }
    }
}
