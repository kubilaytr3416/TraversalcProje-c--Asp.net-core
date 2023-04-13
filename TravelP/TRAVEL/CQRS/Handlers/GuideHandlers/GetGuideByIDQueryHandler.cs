using DataAccessLayer.Concrete;
using MediatR;
using System.Drawing.Printing;
using System.Threading;
using System.Threading.Tasks;
using TRAVEL.CQRS.Queries.GuideQueries;
using TRAVEL.CQRS.Results.GudieResults;

namespace TRAVEL.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        private readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.ID);
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                Description = values.Description,
                Name = values.Name,
              
            };


        }
    }
}
