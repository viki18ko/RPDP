using System;
using System.Collections.Generic;
using NHibernate;
using System.Linq;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class AmountCarRepository : BaseRepository<Entity.AmountCar>
    {
        public static AmountCarRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<AmountCarRepository>(sessionFactory);
        }

        public IList<Int32> GetAmountCar()
        {
            return GetAll().OrderBy(x => x.Number).Select(x => x.Number).ToList();
        }


        public IList<Int32> GetAmountCarOf(Int32 number)
        {
            return GetAll().Where(x => x.Number == number).Select(x => x.Number).ToList();
        }

        public Int32 GetIdByAmountCar(Int32 number)
        {
            return GetAll().SingleOrDefault(x => x.Number == number).Id;
        }
    }
}