using System;
using System.Linq;
using NHibernate;
using System.Collections.Generic;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class TrainRepository : BaseRepository<Entity.Train>
    {
        public static TrainRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<TrainRepository>(sessionFactory);
        }

        public IList<String> GetCarByAmountCars(Int32 amountCar)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Entity.Train>().List<Entity.Train>()
                .Where(x => x.IdAmountCar.Number == amountCar)
                .SelectMany(train => train.Cars).Select(car => car.NumberCar).ToList();
        }

        public IList<String> GetHeadByAmountCars(Int32 amountCar)
        {
            var Cars = GetCarByAmountCars(amountCar);
            Int32 ost, y;
            IList<String> res = new List<String>();
            for (int i = 0; i <= Cars.Count - 1; i++)
            {
                ost = Math.DivRem(i, amountCar, out y);
                if (y == 0)
                {
                    res.Add(Cars[i]);
                }
            }
            return res;
        }

        public IList<Int32> GetIdTrainByAmountCar(Int32 number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Train>().List<Train>()
                    .Where(x => x.IdAmountCar.Number == number).Select(x => x.Id).ToList();
        }

        public IList<String> GetCarByTrain(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Train>().List<Train>()
                    .SelectMany(x => x.Cars).Where(x => x.NumberCar.Equals(number))
                    .Select(x => x.NumberCar).ToList();
        }

        public Int32 GetFirstIdTrainByAmountCar(Int32 number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Train>().List<Train>()
                    .Where(x => x.IdAmountCar.Number == number).Select(x => x.Id).First();
        }
    }
}