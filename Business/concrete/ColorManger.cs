using Business.Abstract;
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

        public void Add(Color color)
        {
            _coloDal.Add(color);
            
        }

        public void Delete(Color color)
        {
            _coloDal.Delete(color);
        }

        public List<Color> GetAll()
        {
            return _coloDal.GetAll();
        }

        public Color GetById(int ColorId)
        {
            return _coloDal.Get(c => c.Id == ColorId);
        }

        public void update(Color color)
        {
            _coloDal.Update(color);
        }
    }
}
