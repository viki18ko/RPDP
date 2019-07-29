using System;
using NHibernate;
using System.Linq;
using System.Collections.Generic;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class RegistrarRepository : BaseRepository<Entity.Registrar>
    {
        public static RegistrarRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<RegistrarRepository>(sessionFactory);
        }

        public String GetTypeRegistrarByNumberRegistrar(String number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Registrar>().List<Registrar>()
                    .Where(x => x.NumberRegistrar.Equals(number))
                    .Select(x => x.IdTypeRegistrar.Type).SingleOrDefault();
        }

        public String GetManufactureDateRegistrarByNumberRegistrar(String number)
        {
            using (var session = OpenSession())
            return session.CreateCriteria<Registrar>().List<Registrar>()
                .Where(x => x.NumberRegistrar.Equals(number))
                .Select(x => x.ManufactureDate).SingleOrDefault().ToString();
        }

        public IList<String> GetRegistrarByTypeRegistrar(String type)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Registrar>().List<Registrar>()
                    .Where(x => x.IdTypeRegistrar.Type.Equals(type))
                    .Select(x => x.NumberRegistrar).ToList();
        }

        public IList<String> GetNumberRegistrar()
        {
            return GetAll().OrderBy(x => x.NumberRegistrar).Select(x => x.NumberRegistrar).ToList();
        }

        public IList<String> GetNumberRegistrarOf(String number)
        {
            return GetAll().Where(x => x.NumberRegistrar.Equals(number)).Select(x => x.NumberRegistrar).ToList();
        }

        public Int32 GetIdByNumberRegistrar(String number)
        {
            return GetAll().Where(x => x.NumberRegistrar.Equals(number)).Select(x => x.Id).SingleOrDefault();
        }

        public Char GetBusyByNumberRegistrar(String number)
        {
            return GetAll().Where(x => x.NumberRegistrar.Equals(number)).Select(x => x.Busy).SingleOrDefault();
        }

        public IList<String> GetNumberRegistrarOfFree(Char busy)
        {
             return GetAll().Where(x => x.Busy == busy).Select(x => x.NumberRegistrar).ToList();
        }
    }
}