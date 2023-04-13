using Microsoft.EntityFrameworkCore;

namespace TraversalSql.Dal
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Visitor> Visitors { get; set; }
    }

}
