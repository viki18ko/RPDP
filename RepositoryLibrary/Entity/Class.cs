using System;
using System.Collections.Generic;


namespace RPDP.RepositoryLibrary.Entity
{
    public class Class:Entity<Class>
    {
        public virtual Int32 NumberClass { get; set; }
        public virtual IList<Employee> Employee { get; set; }

        public Class()
        {
            Employee = new List<Employee>();
        }

        public virtual void AddEmployee(Employee employee)
        {
            employee.IdClass = this;
            Employee.Add(employee);
        }
    }
}
