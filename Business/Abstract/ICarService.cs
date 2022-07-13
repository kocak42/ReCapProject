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
       IDataResult <List<Car>> GetAllByBrandId(int id);
        IDataResult<List<Car>> GetAllByColorId(int id);
        IDataResult<Car> GetById(int id);
        IDataResult <List<CarDetailsDto>> GetCarDetails();

    }
}
