using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class CarMap: ClassMap<Car>
    {
        public CarMap()
        {
            Id(x => x.Id).Column("ID").GeneratedBy.Identity().Not.Nullable().Unique();
            Map(x => x.NumberCar).Column("Number").Length(50).Not.Nullable().Unique();
            References(x => x.IdTypeCar).Column("IdTypeCar").Not.Nullable();
            References(x => x.IdRegistrar).Column("IdRegistrar").Not.Nullable();
            Map(x => x.Busy).Column("Busy").Not.Nullable();
            HasManyToMany(x => x.Trains).Cascade.All().Table("Composition");
        }
    }
}
