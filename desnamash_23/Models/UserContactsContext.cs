using Microsoft.EntityFrameworkCore;

namespace desnamash_23.Models
{
    public class UserContactsContext : DbContext
    {
        public DbSet<UserContact> UserContacts { set; get; }

        public UserContactsContext(DbContextOptions<UserContactsContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
