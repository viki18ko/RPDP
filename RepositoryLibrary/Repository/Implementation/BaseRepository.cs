using System;
using System.Collections.Generic;
using NHibernate;
using RPDP.RepositoryLibrary.Repository.Interfaces;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class BaseRepository<T> : IRepository<T> where T : Entity.Entity<T>
    {
        private static volatile BaseRepository<T> repository;

        private static readonly Object SynchronizationRoot = new Object();

        protected static TRepository GetInstance<TRepository>(ISessionFactory sessionFactory) where TRepository : BaseRepository<T>, new()
        {
            if (sessionFactory == null)
                throw new ArgumentNullException(nameof(sessionFactory));

            if (repository == null)
                lock (SynchronizationRoot)
                    if (repository == null)
                        repository = new TRepository {SessionFactory = sessionFactory};
            return repository as TRepository;
        }

        protected ISessionFactory SessionFactory;

        protected ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        protected BaseRepository(){}

        public T GetById(Int32 id)
        {
            using (var session = OpenSession())
                return session.Get<T>(id);
        }

        public void Save(T entity)
        {
            using (var session = OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.SaveOrUpdate(entity);
                transaction.Commit();
            }
        }

        public void Delete(T entity)
        {
            using (var session = OpenSession())
            using (var transaction = session.BeginTransaction())
            {
                session.Delete(entity);
                transaction.Commit();
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var session = OpenSession())
                return session.CreateCriteria<T>().List<T>();
        }
    }
}