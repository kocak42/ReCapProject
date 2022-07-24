using Business.Abstract;
using Business.Contans;
using Business.ValidationRules.FluenValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _coloDal;

        public ColorManager(IColorDal coloDal)
        {
            _coloDal = coloDal;
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Color color)
        {
            _coloDal.Add(color);
            return new SuccessResult(Messages.ColorAdded);
            
        }

        public IResult Delete(Color color)
        {
            _coloDal.Delete(color);
            return new SuccessResult(Messages.ColorRemoved);
        }

        public IDataResult<List<Color>> GetAll()
        {
            return new SuccessDataResult<List<Color>> (_coloDal.GetAll(),Messages.ColorListed);
        }

        public IDataResult<Color> GetByColorId(int ColorId)
        {
            return new SuccessDataResult<Color>(_coloDal.Get(c => c.ColorId == ColorId), Messages.ColorListed);
        }


        [ValidationAspect(typeof(CarValidator))]
        public IResult Update(Color color)
        {
            _coloDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
