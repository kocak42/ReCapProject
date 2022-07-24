using Core.Utilities.Result;
using Entities.CarDTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
       IDataResult <List<Car>> GetAll();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
       IDataResult <List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllByColorId(int brandId);
        IDataResult<Car> GetByCarId(int carId);
        IDataResult <List<CarDetailsDto>> GetCarDetails();

    }
}
