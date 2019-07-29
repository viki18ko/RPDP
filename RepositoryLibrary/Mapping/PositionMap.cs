using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class PositionMap : ClassMap<Position>
    {
        public PositionMap()
        {
            Id(x => x.Id).Column("ID").GeneratedBy.Identity().Not.Nullable().Unique();
            Map(x => x.NamePosition).Column("Name").Length(255).Not.Nullable().Unique();
            HasMany(x => x.Employee).Cascade.All().Inverse();
        }
    }
}
