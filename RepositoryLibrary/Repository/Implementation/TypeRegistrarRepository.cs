using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class TypeRegistrarRepository : BaseRepository<Entity.TypeRegistrar>
    {
        public static TypeRegistrarRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<TypeRegistrarRepository>(sessionFactory);
        }

        public String GetTypeRegistrarById(Int32 id)
        {
            return GetAll()
                .With(x => x.SingleOrDefault(t => t.Id == id))
                .With(t => t.Type);
        }

        public IList<String> GetTypeRegistrar()
        {
            return GetAll().OrderBy(x => x.Type).Select(x => x.Type).ToList();
        }

        public Int32 GetIdByTypeRegistrar(String type)
        {
            return GetAll().Where(x => x.Type.Equals(type)).Select(x => x.Id).SingleOrDefault();
        }

        public IList<String> GetTypeRegistrarOf(String type)
        {
            return GetAll().Where(x => x.Type.Equals(type)).Select(x => x.Type).ToList();
        }

        public Int32 GetIdTypeRegistrarByNumbeRegistrar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<TypeRegistrar>().List<TypeRegistrar>()
                    .SelectMany(x => x.Registrars)
                    .Where(x => x.NumberRegistrar.Equals(number))
                    .Select(x => x.IdTypeRegistrar.Id).SingleOrDefault();
        }

        public String GetTypeRegistraByNumberRegistrar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<TypeRegistrar>().List<TypeRegistrar>()
                    .SelectMany(x => x.Registrars)
                    .Where(x => x.NumberRegistrar.Equals(number))
                    .Select(x => x.IdTypeRegistrar.Type).SingleOrDefault();
        }
    }
}