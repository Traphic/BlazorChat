﻿using Microsoft.AspNetCore.SignalR;

namespace BlazorChat.Hubs;

public class ChatHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessages", user, message);
    }
}