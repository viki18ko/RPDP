using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class TypeCarMap: ClassMap<TypeCar>
    {
        public TypeCarMap()
        {
            Id(x => x.Id).Column("ID").GeneratedBy.Identity().Not.Nullable().Unique();
            Map(x => x.Type).Column("Type").Length(50).Not.Nullable().Unique();
            HasMany(x => x.Cars).Cascade.All().Inverse();
        }
    }
}
