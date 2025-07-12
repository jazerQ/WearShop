using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public class WearShopContext : IdentityDbContext
{
    public WearShopContext(DbContextOptions<WearShopContext> options) : base(options){}
}
