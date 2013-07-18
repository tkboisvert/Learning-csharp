using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFContract
{
    [ServiceContract(Namespace = "http://tkboisvert.net/FizzTheBuzz")]
    public interface IFizzBuzzService
    {
        [OperationContract]
        string FizzTheBuzz(int startnumber, int endNumber);
    }
}
