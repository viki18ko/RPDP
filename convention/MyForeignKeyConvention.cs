using System;
using FluentNHibernate;
using FluentNHibernate.Conventions;

namespace RPDP.convention
{
    class MyForeignKeyConvention: ForeignKeyConvention
    {
        protected override string GetKeyName(Member property, Type type)
        {
            var refName = property == null ? type.Name : property.Name;
            return String.Format("{0}", refName);
        }
    }
}
