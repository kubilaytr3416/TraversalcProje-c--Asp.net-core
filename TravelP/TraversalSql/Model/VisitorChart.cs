using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;

namespace TraversalSql.Model
{
    public class VisitorChart
    {
        public VisitorChart() 
        {
            Counts = new List<int>();

        }
        public string VisitDate { get; set; }
        public List<int> Counts { get; set;}
    }
}
