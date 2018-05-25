using Microsoft.EntityFrameworkCore;

namespace ShoppingCart.Models
{
    public class ProductContext : DbContext
    {
		public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }

		public DbSet<ShoppingCart.Models.Product> Products { get; set; }
    }
}
