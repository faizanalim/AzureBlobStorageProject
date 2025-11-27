
namespace AzureBlobProject.Services
{
    public class ContainerService : IContainerService
    {
        Task IContainerService.CreateContainer(string containerName)
        {
            throw new NotImplementedException();
        }

        Task IContainerService.DeleteContainer(string containerName)
        {
            throw new NotImplementedException();
        }

        Task<List<string>> IContainerService.GetAllContainer()
        {
            throw new NotImplementedException();
        }

        Task<List<string>> IContainerService.GetAllContainerAndBlobs()
        {
            throw new NotImplementedException();
        }
    }
}
