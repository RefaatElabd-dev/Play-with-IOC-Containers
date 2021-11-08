using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using MVCIOCAutoFac.Modules;

namespace MVCIOCAutoFac.App_Start
{
    public class AutoFacConfig
    {
        public static void CofigureContainer()
        {
            var builder = new ContainerBuilder();

            // register dependencies in controllers
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // register dependencies in filter provider
            builder.RegisterFilterProvider();

            //register dependencies in custom views
            builder.RegisterSource(new ViewRegistrationSource());

            //Register our Repo Dependencies
            builder.RegisterModule(new RepositoryModule());


            var container = builder.Build();

            //set MVC DI Resolver To use AutoFacContainer
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}

