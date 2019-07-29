using FluentNHibernate.Mapping;
using RPDP.RepositoryLibrary.Entity;

namespace RPDP.RepositoryLibrary.Mapping
{
    class RouteMap: ClassMap<Route>
    {
        public RouteMap()
        {
           Id(x => x.Id);
           Map(x => x.NumberRoute).Column("Number").Not.Nullable().Unique();
        }
    }
}
