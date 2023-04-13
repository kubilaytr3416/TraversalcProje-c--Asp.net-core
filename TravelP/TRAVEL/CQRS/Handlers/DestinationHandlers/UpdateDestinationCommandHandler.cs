using DataAccessLayer.Concrete;
using Org.BouncyCastle.Asn1.Cmp;
using TRAVEL.CQRS.Commands.DestinationCommands;

namespace TRAVEL.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationCommandHandler
    {
        private readonly Context _context;

        public UpdateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(UpdateDestinationCommand command)
        {
            var values = _context.Destinations.Find(command.id);
            values.Capacity = command.capacity;
            values.City = command.city;
            values.DayNight = command.daynight;
            values.Price = command.price;
            _context.SaveChanges();
        }
    }
}
