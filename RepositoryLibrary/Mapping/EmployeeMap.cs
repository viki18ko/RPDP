using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Id(x => x.Id);
            Component(x => x.Name);
            References(x => x.IdClass);
            References(x => x.IdPosition);
            Map(x => x.StartDate).Column("StartDate").Nullable();
            References(x => x.IdInstructor);
            HasMany(x => x.Drivers).Cascade.All().Inverse();
        }
    }
}