using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WCFContract
{
    [ServiceContract]
    public interface IFizzBuzzService
    {
        [OperationContract]
        string FizzTheBuzz(int startnumber, int endNumber);
    }
}
