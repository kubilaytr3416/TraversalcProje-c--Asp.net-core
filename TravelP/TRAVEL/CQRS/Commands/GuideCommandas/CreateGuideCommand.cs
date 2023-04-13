using MediatR;

namespace TRAVEL.CQRS.Commands.GuideCommandas
{
    public class CreateGuideCommand:IRequest
    {
       public string Name { get; set; }
        public string Description { get; set; }
    }
}
