﻿using DataAccessLayer.Concrete;
using TRAVEL.CQRS.Queries.DestinationQueries;
using TRAVEL.CQRS.Results.DestinationResults;

namespace TRAVEL.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;
        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                Daynight = values.DayNight,
                Price = values.Price

            };
        }
    }


}