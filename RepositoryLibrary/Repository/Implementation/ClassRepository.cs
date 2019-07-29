using System;
using System.Collections.Generic;
using NHibernate;
using System.Linq;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class ClassRepository : BaseRepository<Entity.Class>
    {
        public static ClassRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<ClassRepository>(sessionFactory);
        }

        public IList<Int32> GetNumberClass()
        {
            return GetAll().OrderBy(x => x.NumberClass).Select(x => x.NumberClass).ToList();
        }

        public IList<Int32> GetClassOf(Int32 number)
        {
            return GetAll().Where(x => x.NumberClass == number).Select(x => x.NumberClass).ToList();
        }

        public Int32 GetIdByClass(Int32 number)
        {
            return GetAll().Where(x => x.NumberClass == number).Select(x => x.Id).SingleOrDefault();
        }
    }
}