using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseContext
{
    public class TSWContext : DbContext
    {
        public TSWContext() : base("TSWContext")
        {
            
        }
        public DbSet<Model.Event> Events { get; set; }
    }
}
