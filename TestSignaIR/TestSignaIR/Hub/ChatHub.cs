using Microsoft.AspNetCore.SignalR;
namespace TestSignaIR.Hub
{
    public class ChatHub : Microsoft.AspNetCore.SignalR.Hub
    { 
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
