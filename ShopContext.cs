using Microsoft.EntityFrameworkCore;

namespace Relations
{
    public class ShopContext 
        :DbContext
    {
        public ShopContext(
            DbContextOptions<ShopContext> options)
            :base(options)
        {

        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating
            (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>(op => {
                op.ToTable(nameof(Orders));
                op.HasKey(p => p.Id);
                op.Property(p => p.Buyer).IsRequired()
                .HasMaxLength(128);
                op.Property(p => p.ShopingDate).IsRequired();

                op.HasMany(p=>p.Items)
                .WithOne(p=>p.Order)
                .HasForeignKey(p=>p.OrderId);
            });

            modelBuilder.Entity<OrderItem>(op => {
                op.ToTable(nameof(OrderItems));
                op.HasKey(p => p.Id);
                op.Property(p => p.ProductName).IsRequired()
                .HasMaxLength(128);
                op.Property(p => p.UnitPrice).IsRequired();
                op.Property(p => p.Quantity).IsRequired();

            });
        }
    }
}
