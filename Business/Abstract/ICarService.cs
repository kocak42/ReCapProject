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
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
       IDataResult <List<CarDetailsDto>> GetCarDetailByBrandId(int brandId);
        IDataResult<List<CarDetailsDto>> GetCarDetailByColorId(int colorId);
        IDataResult<Car> GetByCarId(int carId);
        IDataResult<List<CarDetailsDto>> GetCarDetails();
        IDataResult<List<CarDetailsDto>> GetCarDetailsByColorAndBrand(int brandId, int colorId);


    }
}
