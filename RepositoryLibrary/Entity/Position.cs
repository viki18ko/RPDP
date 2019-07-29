using System;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Entity
{
    public class Position:Entity<Position>
    {
        public virtual String NamePosition { get; set; }
        public virtual IList<Employee> Employee { get; set; }

        public Position()
        {
            Employee = new List<Employee>();
        }

        public virtual void AddEmployee(Employee employee)
        {
            employee.IdPosition = this;
            Employee.Add(employee);
        }
    }
}
