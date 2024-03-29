﻿using Microsoft.AspNetCore.SignalR;
using SignalR.Model;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class VisitorHub:Hub
    {
        private readonly VisitorService _visitorService;

        public VisitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("CallVisitList","bb");
        }
    }
}
