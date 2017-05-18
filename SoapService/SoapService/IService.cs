using System.Runtime.Serialization;
using System.ServiceModel;

namespace SoapService
{
    [ServiceContract]
    public interface IService
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        bool SendKeyPress();

    }
}
