using DocumentFormat.OpenXml.Office2010.ExcelAc;
using MediatR;
using System.Collections.Generic;
using TRAVEL.CQRS.Results.DestinationResults;
using TRAVEL.CQRS.Results.GudieResults;

namespace TRAVEL.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
