using System.ServiceModel;
using System.Threading.Tasks;
using Microsoft.ServiceFabric.Services.Remoting;

namespace AppShared
{
    //[ServiceContract]
    public interface IGatewayService : IService
    {
        //[OperationContract]
        Task<Message> GetMessage();
    }
}
