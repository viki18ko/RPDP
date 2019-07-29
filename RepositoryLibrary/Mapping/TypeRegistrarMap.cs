using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class TypeRegistrarMap: ClassMap<TypeRegistrar>
    {
        public TypeRegistrarMap()
        {
            Id(x => x.Id).Column("ID").GeneratedBy.Identity().Not.Nullable().Unique();
            Map(x => x.Type).Column("Type").Length(50).Not.Nullable().Unique();
            HasMany(x => x.Registrars).Cascade.All().Inverse();
        }
    }
}
