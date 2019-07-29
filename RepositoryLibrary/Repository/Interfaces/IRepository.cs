using System;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Repository.Interfaces
{
    public interface IRepository<T> where T : Entity.Entity<T>
    {
        T GetById(Int32 id);
        void Save(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
    }
}