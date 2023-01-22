using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework2.Server.Data.Repositories
{
     public interface IBaseRepository<T>
    {
        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);

        Task<T> FindAsync(Guid Id);

        Task<IEnumerable<T>> GetAllAsync();

        Task<bool> SaveChangesAsync();
    }
}
