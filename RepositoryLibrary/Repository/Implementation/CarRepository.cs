using System;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class CarRepository : BaseRepository<Entity.Car>
    {
        public static CarRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<CarRepository>(sessionFactory);
        }

        public IList<String> GetNumberCar()
        {
            return GetAll().OrderBy(x => x.NumberCar).Select(x => x.NumberCar).ToList();
        }

        public IList<String> GetCarByTypeCar(String type)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .Where(x => x.IdTypeCar.Type.Equals(type))
                    .Select(x => x.NumberCar)
                    .ToList();
        }

        public IList<String> GetCarByTypeCarAndBusy(String type, Char busy)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .Where(x => x.IdTypeCar.Type.Equals(type))
                    .Where(x => x.Busy == busy)
                    .Select(x => x.NumberCar)
                    .ToList();
        }


        public Int32 GetIdRegistrarByNumberCar(String numberCar)
        {
            return GetAll()
                .SingleOrDefault(x => x.NumberCar == numberCar)
                .With(reg => reg.IdRegistrar).Id;
        }

        public IList<String> GetCarsByHead(String head)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Entity.Car>().List<Entity.Car>()
                    .SingleOrDefault(car => car.NumberCar.Equals(head))
                    .With(car => car.Trains)
                    .SelectMany(train => train.Cars)
                    .Select(car => car.NumberCar)
                    .ToList();
        }

        public String GetNumberRegistrarByNumberCar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .SingleOrDefault(x => x.NumberCar.Equals(number))
                    .IdRegistrar.NumberRegistrar;
        }

        public String GetTypeRegistrarByNumberCar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .SingleOrDefault(x => x.NumberCar.Equals(number))
                    .IdRegistrar.IdTypeRegistrar.Type;
        }

        public String GetTypeCarByNumberCar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .SingleOrDefault(x => x.NumberCar.Equals(number))
                    .IdTypeCar.Type;
        }

        public DateTime GetManufactureDateByNumberCar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .SingleOrDefault(x => x.NumberCar.Equals(number))
                    .IdRegistrar.ManufactureDate;
        }

        public IList<String> GetNumberCarByNumberRegistar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .Where(x => x.IdRegistrar.NumberRegistrar.Equals(number))
                    .Select(x => x.NumberCar).ToList();
        }

        public IList<String> GetNumberCarOf(String number)
        {
            return GetAll().Where(x => x.NumberCar.Equals(number)).Select(x => x.NumberCar).ToList();
        }

        public Int32 GetIdByNumberCar(String number)
        {
            return GetAll().Where(x => x.NumberCar.Equals(number)).Select(x => x.Id).SingleOrDefault();
        }

        public Char GetBusyByNumberCar(String number)
        {
            return GetAll().Where(x => x.NumberCar.Equals(number)).Select(x => x.Busy).SingleOrDefault();
        }

        public IList<String> GetNumberCarByBusy(Char busy)
        {
            return GetAll().Where(x => x.Busy == busy)
                    .Select(x => x.NumberCar).ToList();
        }

        public Int32 GetIdTypeCarByNumberCar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .SingleOrDefault(x => x.NumberCar.Equals(number))
                    .IdTypeCar.Id;
        }

        public Int32 GetIdTypeRegistrarByNumberCar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Car>().List<Car>()
                    .SingleOrDefault(x => x.NumberCar.Equals(number))
                    .IdRegistrar.IdTypeRegistrar.Id;
        }
    }
}