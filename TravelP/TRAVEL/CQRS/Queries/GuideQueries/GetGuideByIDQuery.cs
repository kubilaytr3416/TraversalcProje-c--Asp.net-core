using DocumentFormat.OpenXml.Office2010.Excel;
using MediatR;
using TRAVEL.CQRS.Results.GudieResults;

namespace TRAVEL.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int ıD)
        {
            ID = ıD;
        }

        public int ID { get; set; }
    }
}
