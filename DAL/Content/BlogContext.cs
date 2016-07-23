using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.Entity; 

namespace DAL.Content
{
    class BlogContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Review> Reviews { get; set; }


        public BlogContext(string connectionString) : base(connectionString)
        {}
    }
}
