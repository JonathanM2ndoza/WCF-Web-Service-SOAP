﻿using Demo_WS_SOAP.Domain;
using System.ServiceModel;

namespace Demo_WS_SOAP.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITestService" in both code and config file together.
    [ServiceContract]
    public interface ITestService
    {

        [OperationContract]
        string GetData(int value, int value2);

        [OperationContract]

        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }
}
