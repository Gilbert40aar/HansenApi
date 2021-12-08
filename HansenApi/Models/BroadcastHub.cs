using HansenApi.Interfaces;
using Microsoft.AspNetCore.SignalR;

namespace HansenApi.Models
{
    public class BroadcastHub : Hub<IHubClient>
    {
    }
}
