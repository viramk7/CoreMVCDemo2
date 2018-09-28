using CoreMVCDemo2.Data;
using CoreMVCDemo2.Models.BaseEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace CoreMVCDemo2.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        #region Initialization

        protected readonly StudentDbContext _context;
        protected readonly DbSet<T> entities;

        public GenericRepository(StudentDbContext context)
        {
            _context = context;
            entities = context.Set<T>();
        }

        #endregion

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return entities.Where(predicate).AsEnumerable();
        }

        public T Insert(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            entities.Add(entity);
            return entity;
        }

        public void Insert(IList<T> list)
        {
            if (list == null)
                throw new ArgumentNullException("list");

            entities.AddRange(list);
        }

        public T Update(T entity)
        {
            if (entity == null)
                throw new ArgumentNullException("entity");

            _context.Attach(entity).State = EntityState.Modified;
            return entity;
        }

        public void Delete(T entity)
        {
            entities.Remove(entity);
        }

        public void Delete(IList<T> list)
        {
            entities.RemoveRange(list);
        }

        public IEnumerable<T> ExecuteSql(string commandText, params object[] parameters)
        {
            // return new List<TEntity>();
            /*******************************************************************************************
            // TODO: Find a way to execute stored procedures with ad hoc  classes/ arbitary datatypes //
            *******************************************************************************************/

            if (parameters == null && parameters.Length <= 0)
                return _context.Set<T>().FromSql(commandText, parameters);

            var count = 0;
            foreach (var param in parameters)
            {
                var p = param as DbParameter;

                if (p == null)
                    throw new Exception("Invalid parameter");

                commandText += count == 0 ? " " : ",";

                commandText += '@' + p.ParameterName;

                count++;
            }

            return _context.Set<T>().FromSql(commandText, parameters);
        }

    }
}
