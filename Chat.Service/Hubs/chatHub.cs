using Chat.Service.Models;
using Microsoft.AspNetCore.SignalR;

namespace Chat.Service.Hubs;

public class chatHub : Hub
{
    public async Task JoinChat(UserConnection connection)
    {
        await Clients.All.SendAsync("ReceiveMessage", "admin", $"{connection.userName} has joined");
    }

    public async Task JoinSpecificChatRoom(UserConnection connection)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, connection.chatRoom);
        await Clients.Group(connection.chatRoom).SendAsync("ReceiveMessage", "admin",
            $"{connection.userName} has joined {connection.chatRoom}");
    }
}