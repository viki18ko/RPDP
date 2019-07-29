using System;
using System.Collections.Generic;
using NHibernate;
using System.Linq;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class RouteRepository : BaseRepository<Entity.Route>
    {
        public static RouteRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<RouteRepository>(sessionFactory);
        }

        public Int32 GetIdByNumberRoute(Int32 number)
        {
            return GetAll().Where(x => x.NumberRoute == number).Select(x => x.Id).SingleOrDefault();
        }

        public IList<Int32> GetNumberRouteOf(Int32 number)
        {
            return GetAll().Where(x => x.NumberRoute == number).Select(x => x.NumberRoute).ToList();
        }

        public IList<String> GetNumberRoute()
        {
            return GetAll().OrderBy(x => x.NumberRoute)
                .Select(x => x.NumberRoute.ToString("00")).ToList();
        }
    }
}