using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class AmountCarMap: ClassMap<AmountCar>
    {
        public AmountCarMap()
        {
            Id(x => x.Id);
            Map(x => x.Number).Column("Number").Not.Nullable().Unique();
            HasMany(x => x.Trains).KeyColumn("IdAmountCar").Inverse().Cascade.All();
        }
    }
}
