using System;
using System.Collections.Generic;

namespace RPDP.RepositoryLibrary.Entity
{
    public class Employee : Entity<Employee>
    {
        public virtual Name Name { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual Position IdPosition { get; set; }
        public virtual Class IdClass { get; set; }
        public virtual Employee IdInstructor { get; set; }
        public virtual IList<Employee> Drivers { get; set; }

        public Employee()
        {
            Drivers = new List<Employee>();
        }
    }
}