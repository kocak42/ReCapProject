using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
           using(CarsContext context=new CarsContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }

        }

        public void Delete(Car entity)
        {
            using(CarsContext context=new CarsContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            using (CarsContext context = new CarsContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using(CarsContext context=new CarsContext())
            {
                
                return filter == null ? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
                
            }
        }

        public List<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            using(CarsContext context=new CarsContext())
            {
                var changedEntity = context.Entry(entity);
                changedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}
