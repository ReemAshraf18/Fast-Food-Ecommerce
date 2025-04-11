using Microsoft.EntityFrameworkCore;
using Models;
public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {
    }
    public DbSet<Item> Items { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<SubCategory> SubCategories { get; set; }
    public DbSet<OrderHeader> OrderHeaders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Coupon> Coupons { get; set; }
    public DbSet<Cart> Carts { get; set; }

}
