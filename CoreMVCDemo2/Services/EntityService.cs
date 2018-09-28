using CoreMVCDemo2.Models.BaseEntity;
using CoreMVCDemo2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CoreMVCDemo2.Services
{
    public class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        #region Initialization

        IGenericRepository<T> _genericRepository;
        IUnitOfWork _unitOfWork;

        public EntityService(IGenericRepository<T> genericRepository,
                             IUnitOfWork unitOfWork)
        {
            _genericRepository = genericRepository;
            _unitOfWork = unitOfWork;
        }

        #endregion

        #region Methods

        public IEnumerable<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public IEnumerable<T> FindBy(Expression<Func<T,bool>> predicate)
        {
            return _genericRepository.FindBy(predicate);
        }

        public T Insert(T entity)
        {
            _genericRepository.Insert(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public void Insert(IList<T> list)
        {
            _genericRepository.Insert(list);
            _unitOfWork.Commit();
        }

        public T Update(T entity)
        {
            _genericRepository.Update(entity);
            _unitOfWork.Commit();
            return entity;
        }

        public void Delete(T entity)
        {
            _genericRepository.Delete(entity);
            _unitOfWork.Commit();
        }

        public void Delete(IList<T> list)
        {
            _genericRepository.Delete(list);
            _unitOfWork.Commit();
        }

        public IEnumerable<T> ExecuteSql(string commandText, params object[] parameters)
        {
            return _genericRepository.ExecuteSql(commandText, parameters);
        }

        #endregion

    }
}
