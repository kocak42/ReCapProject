using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.NHibernate
{
    public class NhEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
          where TEntity : class, IEntity, new()
    {
        private NHibernateHelper _nHibernateHelper;
        public void Add(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Save(entity);
            }
        }

        public void Delete(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Delete(entity);
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return session.Query<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                return filter == null ? session.Query<TEntity>().ToList() : session.Query<TEntity>().Where(filter).ToList();
            }
        }

        public List<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            using (var session = _nHibernateHelper.OpenSession())
            {
                session.Update(entity);
            }
        }
    }
}
