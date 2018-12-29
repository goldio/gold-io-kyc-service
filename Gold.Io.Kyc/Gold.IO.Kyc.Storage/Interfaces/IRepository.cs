using Gold.IO.Kyc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gold.IO.Kyc.Storage.Interfaces
{
    public interface IRepository<T> where T : PersistentObject
    {
        T Load(object nodeId);

        T Get(long id);

        IQueryable<T> GetAll();

        ISQLQuery ExecuteSqlQuery(string sqlQuery);

        void Add(T entity);

        void Update(T entity);

        void Remove(T entity);
    }
}
