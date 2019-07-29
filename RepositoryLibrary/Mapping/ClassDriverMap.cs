using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class ClassDriverMap : ClassMap<Class>
    {
        public ClassDriverMap()
        {
            Id(x => x.Id);
            Map(x => x.NumberClass).Column("Number").Not.Nullable().Unique();
            HasMany(x => x.Employee).Cascade.All().Inverse();
        }
    }
}
