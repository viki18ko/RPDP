using System;
using NHibernate;
using System.Linq;
using System.Collections.Generic;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Repository.Implementation
{
    public class EmployeeRepository : BaseRepository<Entity.Employee>
    {
        public static EmployeeRepository GetInstance(ISessionFactory sessionFactory)
        {
            return GetInstance<EmployeeRepository>(sessionFactory);
        }

        public String GetPositionByEmployeeName(Name name)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Employee>().List<Employee>()
                    .SingleOrDefault(x => x.Name.Equals(name))
                    .IdPosition.NamePosition;
        }

        public IList<Name> GetNameChiefByNamePosition(String driver, String instructor, String mechanic)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Employee>().List<Employee>()
                .Where(x => !x.IdPosition.NamePosition.Equals(driver) 
                && !x.IdPosition.NamePosition.Equals(instructor)
                && !x.IdPosition.NamePosition.Equals(mechanic))
                .Select(x => x.Name).ToList();
        }

        public String GetNameInstructorByNameDriver(Name name)
        {
            return GetAll()
                    .SingleOrDefault(x => x.Name.Equals(name))
                    .IdInstructor.Name.ToString();
        }

        public Int32 GetClassByName(Name name)
        {
            using (var session = OpenSession())
            return session.CreateCriteria<Employee>().List<Employee>()
                    .SingleOrDefault(x => x.Name.Equals(name)).
                    IdClass.NumberClass;
        }

        public IList<Int32> GetNumberClassEmployee(Int32 number)
        {
            return GetAll().Where(x => x.IdClass.NumberClass == number).Select(x => x.IdClass.NumberClass).ToList();
        }

        public IList<Name> GetNameEmployee()
        {
            return GetAll().OrderBy(x => x.Name.Surname + x.Name.name + x.Name.Patronymic).Select(x => x.Name).ToList();
        }

        public DateTime GetStartDateByName(Name name)
        {
            return GetAll().SingleOrDefault(x => x.Name.Equals(name))
                .StartDate;
        }

        public String GetInitialsByName(Name name)
        {
            return GetAll().Where(x => x.Name.Equals(name)).
                Select(x => (String.Format("{0} {1}. {2}.", x.Name.Surname, x.Name.name.First(),
                x.Name.Patronymic.First()))).SingleOrDefault();
        }

        public String GetSurnameByName(Name name)
        {
            return GetAll().Where(x => x.Name.Equals(name)).
                Select(x => x.Name.Surname).SingleOrDefault();
        }

        public String GetNameByName(Name name)
        {
            return GetAll().Where(x => x.Name.Equals(name)).
                Select(x => x.Name.name).SingleOrDefault();
        }

        public String GetPatronymicByName(Name name)
        {
            return GetAll().Where(x => x.Name.Equals(name)).
                Select(x => x.Name.Patronymic).SingleOrDefault();
        }

        public IList<Name> GetNameEmployeeByNamePosition(String namePosition)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Employee>().List<Employee>()
                    .Where(x => x.IdPosition.NamePosition.Equals(namePosition))
                    .Select(x => x.Name).ToList();
        }

        public IList<Name> GetDriverByNameClass(String namePosition, Int32 number)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Employee>().List<Employee>()
                    .Where(x => x.IdPosition.NamePosition.Equals(namePosition) && x.IdClass.NumberClass.Equals(number))
                    .Select(x => x.Name).ToList();
        }

        public IList<Name> GetEmployeeByPosition(String position)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Employee>().List<Employee>()
                    .Where(x => x.IdPosition.NamePosition.Equals(position))
                    .Select(x => x.Name).ToList();
        }

        public Int32 GetIdByEmployee(Name name)
        {
            return GetAll().Where(x => x.Name.Equals(name)).Select(x => x.Id).SingleOrDefault();
        }

        public List<Name> GetNameInstructor(String namePosition, Name name)
        {
            using (var session = OpenSession())
                return session.CreateCriteria<Employee>().List<Employee>()
                    .Where(x => x.IdPosition.NamePosition.Equals(namePosition))
                    .Where(x => x.IdInstructor.Name.Equals(name))
                    .Select(x => x.Name).ToList();
        }
    }
}