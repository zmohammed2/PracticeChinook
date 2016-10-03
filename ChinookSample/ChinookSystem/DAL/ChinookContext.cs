using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Entities;
#endregion

namespace ChinookSystem.DAL
{
    //iinternal for security reasons 
    //access restricted within the component library
    //inherit dbcontext for entity framework
    //requires System.Data.Entity
   internal class ChinookContext:DbContext
    {
        //Pass the connection string name to the 
        //DbContext using the :base()
        public ChinookContext(): base("chinookDB")
        {

        }

        //setup Dbset properties
        public DbSet<Artist>Artists { get; set; }
        public DbSet<Album>Albums { get; set; }
        public DbSet<Track>Tracks { get; set; }
        public DbSet<MediaType>MediaTypes { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
