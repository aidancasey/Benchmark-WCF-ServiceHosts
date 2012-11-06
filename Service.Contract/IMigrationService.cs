using System.ServiceModel;

namespace Service.Contract
{

    [ServiceContract(Namespace = "http://foo.MigrationService.Contract")]
    public interface IMigrationService
    {
        [OperationContract]
        string MigrateSingleClient(string clientCode);

    }
}
