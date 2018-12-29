using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;

namespace ChatApp
{   //server
    //send all clients any updates
    //end point client
    [HubName("chat")]
    public class ChatHub : Hub
    {
        public void Sendmessage(string message)
        {
            Clients.All.receivemessage(message);
        }
    }
}