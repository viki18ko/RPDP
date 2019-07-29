using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class PositionRepository : BaseRepository<Entity.Position>
    {
        public static PositionRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<PositionRepository>(sessionFactory);
        }

        public IList<String> GetNamePosition()
        {
            return GetAll().OrderBy(x => x.NamePosition).Select(x => x.NamePosition).ToList();
        }

        public String GetPositionByEmploeeName(Entity.Name name)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Entity.Position>().List<Entity.Position>()
                    .SelectMany(e => e.Employee)
                .SingleOrDefault(e => e.Name.Equals(name))
                .IdPosition.NamePosition;
        }

        public IList<String> GetPositionOf(String position)
        {
            return GetAll().Where(x => x.NamePosition.Equals(position))
                .Select(x => x.NamePosition).ToList();
        }

        public Int32 GetIdByPosition(String position)
        {
            return GetAll().Where(x => x.NamePosition.Equals(position)).Select(x => x.Id).SingleOrDefault();
        }
    }
}