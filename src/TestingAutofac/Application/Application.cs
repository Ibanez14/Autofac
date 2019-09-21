using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    public class Application : IApplication
    {
        IBusinessLogic _businessLogic;

        public Application(IBusinessLogic businessLogic)
        {
            _businessLogic = businessLogic;
        }


        public void Run()
        {

            Console.WriteLine("From Applcation class");
            _businessLogic.ProcessData();

        }
    }
}
