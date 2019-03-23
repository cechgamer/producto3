using System.Data.Entity;

namespace Api2.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext 
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<Api2.Models.Product> Products { get; set; }
    }
}