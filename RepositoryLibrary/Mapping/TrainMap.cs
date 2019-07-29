using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class TrainMap: ClassMap<Train>
    {
        public TrainMap()
        {
            Id(x => x.Id).Column("ID").GeneratedBy.Identity().Not.Nullable().Unique();
            References(x => x.IdAmountCar).Column("IdAmountCar");
            HasManyToMany(x => x.Cars).Inverse().Cascade.All().Table("Composition");
        }
    }
}
