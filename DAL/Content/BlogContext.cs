using System.Data.Entity;

namespace DAL.Content
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("DBConnection") { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Creating many-to-manytable

            modelBuilder.Entity<Tag>().HasMany(c => c.Posts)
                .WithMany(s => s.Tags)
                .Map(t => t.MapLeftKey("TagId")
                .MapRightKey("PostId")
                .ToTable("PostTag"));
        }
    }

}
