using Autofac;
using Autofac.Core;
using DemoLibrary;
using DemoLibrary.Utilitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Testing;

namespace ComparerTesting
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<Application>().As<IApplication>();
            containerBuilder.RegisterType<BusinessLogic>().As<IBusinessLogic>();

            containerBuilder.RegisterType<Logger>().As<ILogger>();
            containerBuilder.RegisterType<DataAccess>().As<IDataAccess>();


            // THe Bellow is the same as above 2 ones
            // The same as above => Good Practise
            // Hey, give me all the types in a 
            containerBuilder.RegisterAssemblyTypes(Assembly.Load(nameof(DemoLibrary)))
                //Not all types, only the ones that in UTILITIES namespace
                .Where(type => type.Namespace.Contains("Utilites"))
                .As(type => type.GetInterfaces()
                            .FirstOrDefault(i => i.Name == "I" + type.Name)); // that inherit from this one


            return containerBuilder.Build();
        }
    }
}
