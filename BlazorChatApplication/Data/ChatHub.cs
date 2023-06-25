using Microsoft.AspNetCore.SignalR;

namespace BlazorChatApplication.Data
{
    public class ChatHub : Hub
    {
        public async Task SendMessageAsync(string username, string message)
        {
            await Clients.All.SendAsync(Constants.ReceiveMessageMethodName, username, message);
        }
    }
}
