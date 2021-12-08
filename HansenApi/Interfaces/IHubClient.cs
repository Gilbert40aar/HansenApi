using System.Threading.Tasks;

namespace HansenApi.Interfaces
{
    public interface IHubClient
    {
        Task BroadcastMessage();
    }
}
