using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Autofac;
using MVCIOCAutoFac.Repositories;

namespace MVCIOCAutoFac.Modules
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DataRepositry>().As<IDataRepository>().
                InstancePerRequest();
            builder.RegisterType<UserRepository>().AsImplementedInterfaces();

            builder.RegisterType<UserProvider>().As<IUserProvider>().SingleInstance();

            base.Load(builder);

        }
    }
}