using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationScreening.Domain.Interfaces
{
    interface IRepository<T>
    {
        TEntity GetById<TEntity>(object id)
            where TEntity : class, IEntity;

        List<T> GetList(IFilter<T> filter = null);

        void Update<TEntity>(TEntity entity, int? modifiedBy = null)
            where TEntity : class, IEntity;

        void Delete<TEntity>(TEntity entity, int? modifiedBy = null)
            where TEntity : class, IEntity;
    }
}
