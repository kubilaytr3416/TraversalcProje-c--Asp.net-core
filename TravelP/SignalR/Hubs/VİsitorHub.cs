using Microsoft.AspNetCore.SignalR;
using SignalR.Model;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class VİsitorHub:Hub
    {
        private readonly VisitorService _visitorService;

        public VİsitorHub(VisitorService visitorService)
        {
            _visitorService = visitorService;
        }
        public async Task GetVisitorList()
        {
            await Clients.All.SendAsync("GetVisitList",_visitorService.GetVisitorChartsList());
        }
    }
}
