using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationScreening.Domain.Interfaces
{
    public interface IRepository<T> where T : class, IEntity
    {
        Task<T> GetById(object id);

        Task<List<T>> GetList(List<IFilter<T>> filters = null);

        void Update(T entity);

        void Create(T entity);

        void Delete(T entity);

        Task SaveAsync();
    }
}
