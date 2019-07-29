using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    public class NameMap : ComponentMap<Name>
    {
        public NameMap()
        {
            Map(x => x.name).Not.Nullable().Length(50).Column("Name");
            Map(x => x.Surname).Not.Nullable().Length(50);
            Map(x => x.Patronymic).Not.Nullable().Length(50);
        }
    }
}