using System;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using RPDP.RepositoryLibrary.Mapping;

namespace RPDP.RepositoryLibrary.Repository
{
    public static class SessionFactory
    {
        public static ISessionFactory GetSessionFactory(String connectionString)
        {
            var configuration = Fluently.Configure()
                        .Database(
                            MsSqlConfiguration
                                .MsSql2008
                                .ConnectionString(connectionString))
                        .Mappings(m => m.FluentMappings.AddFromAssembly(typeof(Program).Assembly)
                        .Conventions.Add<MyForeignKeyConvention>())
                        .BuildConfiguration();
            return configuration.BuildSessionFactory();
        }
    }
}