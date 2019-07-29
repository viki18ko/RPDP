using System;
using FluentNHibernate;
using FluentNHibernate.Conventions;

namespace RPDP.RepositoryLibrary.Mapping
{
    public class MyForeignKeyConvention : ForeignKeyConvention
    {
        protected override String GetKeyName(Member property, Type type)
        {
            return property != null ? $" {property.Name}" : $" Id{type.Name}";
        }
    }
}