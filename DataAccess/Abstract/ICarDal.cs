using Core.DataAccess;
using Entities.CarDTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface ICarDal:IEntityRepository<Car>
    {
        List<CarDetailsDto> GetCarDetails();
        List<Car> GetById(Expression<Func<Car, bool>> filter, int id);
        List<CarDetailsDto> GetCars();
        List<CarDetailsDto> GetCarsByBrandId(Expression<Func<Car, bool>> filter, int brandId);
        List<CarDetailsDto> GetCarsByColorId(Expression<Func<Car, bool>> filter, int colorId);
    }
}
