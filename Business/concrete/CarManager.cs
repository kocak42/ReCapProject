﻿using Business.Abstract;
using Business.Contans;
using Business.ValidationRules.FluenValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.CarDTOs;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]

        public IResult Add(Car car)
        {
            _carDal.Add(car);

           
            
            return new SuccessResult(Messages.CarAdded);
            
        }
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarRemoved);
        }
        [CacheAspect]
        public IDataResult<Car> GetByCarId(int carID)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carID));
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<Car>>(Messages.MintenanceTime);
            }
            return new SuccessDataResult<List<Car>>( _carDal.GetAll());
        }

        public IDataResult<List<Car>> GetAllByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetAll(p => p.BrandId == id).ToList(),Messages.CarListed);
        }

        public IDataResult<List<Car>> GetAllByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>( _carDal.GetAll(p => p.ColorId == id).ToList(),Messages.CarListed);
        }

        public IDataResult<List<CarDetailsDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>> (_carDal.GetCarDetails()); 
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarSerice.Get")]
        public IResult  Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
