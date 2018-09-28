using CoreMVCDemo2.Models.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CoreMVCDemo2.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();

        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);

        T Insert(T entity);

        void Insert(IList<T> list);

        T Update(T entity);

        void Delete(T entity);

        void Delete(IList<T> list);

        IEnumerable<T> ExecuteSql(string commandText, params object[] parameters);
    }
}
