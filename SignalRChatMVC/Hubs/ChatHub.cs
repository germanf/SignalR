﻿using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignalRChatMVC.Hubs
{
    public class ChatHub: Hub
    {
        public void Send(string name, string msg)
        {
            Clients.All.addNewMessageToPage(name, msg);
        }
    }
}