using DataAccess.Entities.Users;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class WearShopContext : IdentityDbContext
{
    public DbSet<User> Users { get; set; }
    
    public WearShopContext(DbContextOptions<WearShopContext> options) : base(options){}
}
