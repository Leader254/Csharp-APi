using csharp_crud_api.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_crud_api.Data
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
