using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Autofac;
using Testing;

namespace ComparerTesting
{



    public class MainProgram
    {
        static void Main(string[] args)
        {
            // Give me the container with all registered types
            IContainer container = ContainerConfig.Configure();

            using (ILifetimeScope scope = container.BeginLifetimeScope())
            {
                IApplication app = scope.Resolve<IApplication>();
                app.Run();
            }
            Console.Read();

        }
    }






}







