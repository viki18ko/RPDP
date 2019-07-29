using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class RegistrarMap: ClassMap<Registrar>
    {
        public RegistrarMap()
        {
            Id(x => x.Id).Column("ID").GeneratedBy.Identity().Not.Nullable().Unique();
            Map(x => x.NumberRegistrar).Column("Number").Length(50).Not.Nullable().Unique();
            References(x => x.IdTypeRegistrar).ForeignKey("IdTypeRegistrar").Not.Nullable();
            Map(x => x.ManufactureDate).Column("ManufactureDate");
            Map(x => x.Busy).Column("Busy").Not.Nullable();
            HasMany(x => x.Cars).Cascade.All().Inverse();
        }
    }
}
