using Autofac;
using System;

namespace CustomAutofac.Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // CCBBRR (Create, configure, Build CONRAINER)

            // 1) Creating container builder
            // 2) Configure services
            // 3) Building the container
            // 4) Begin scope
            // 5) Resolve service
            // 6) Run application

            // 1) 
            var builder = new ContainerBuilder();
            // 2) 
            builder.RegisterType<Writer>().As<IWriter>();
            builder.RegisterType<Application>().As<IApplication>();
            // 3) 
            IContainer container = builder.Build();

            //4) 
            using (var scope = container.BeginLifetimeScope())
            {
                //5
                IApplication app = scope.Resolve<IApplication>();
                //6
                app.Run();
            }


            Console.Read();

        }


        public class Application : IApplication
        {
            readonly IWriter writer;
            public Application(IWriter writer) =>
                this.writer = writer;


            public void Run()
            {
                Console.WriteLine("App is launched");
                writer.Write();
            }

        }


        public class Writer : IWriter
        {
            public void Write() =>
                Console.WriteLine("Writing a data");
        }
    }
}