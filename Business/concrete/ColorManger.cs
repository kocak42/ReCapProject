using Business.Abstract;
using Business.Contans;
using Core.Utilities.Result;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.concrete
{
    public class ColorManger : IColorService
    {
        IColorDal _coloDal;

        public ColorManger(IColorDal coloDal)
        {
            _coloDal = coloDal;
        }

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

        public IDataResult<Color> GetById(int ColorId)
        {
            return new SuccessDataResult<Color>( _coloDal.Get(c => c.Id == ColorId),Messages.ColorListed);
        }

        public IResult Update(Color color)
        {
            _coloDal.Update(color);
            return new SuccessResult(Messages.ColorUpdated);
        }
    }
}
