using System;
using System.Linq;
using NHibernate;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class TypeCarRepository : BaseRepository<Entity.TypeCar>
    {
        public static TypeCarRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<TypeCarRepository>(sessionFactory);
        }

        public Int32 GetIdByType(String typeCar)
        {
            return GetAll()
                .Where(x => x.Type == typeCar)
                .Select(x => x.Id)
                .SingleOrDefault();
        }

        public IList<String> GetTypeCar()
        {
            return GetAll().OrderBy(x => x.Type).Select(x => x.Type).ToList();
        }

        public Int32 GetIdByTypeCar(String type)
        {
            return GetAll().Where(x => x.Type.Equals(type)).Select(x => x.Id).SingleOrDefault();
        }

        public IEnumerable<String> GetTypeCarOf(String type)
        {
            return GetAll().Where(x => x.Type.Equals(type)).Select(x => x.Type);
        }
    }
}