using DemoLibrary.Utilitites;
using System;

namespace DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {

        ILogger _Logger;
        IDataAccess _DataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            _Logger = logger;
            _DataAccess = dataAccess;
        }



        public void ProcessData()
        {
            _Logger.LogData("Logger.LogData from BusinessLogic");

        }
    }
}
