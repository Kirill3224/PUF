using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PI.DAL.Entities.Orders;

namespace PI.DAL.Configurations;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.HasKey(oi => oi.Id);

        builder.HasOne(oi => oi.Product)
               .WithMany() 
               .HasForeignKey(oi => oi.ProductId)
               .IsRequired();

        builder.Property(oi => oi.UnitPrice)
               .HasColumnType("decimal(18,2)")
               .IsRequired();

        builder.Property(oi => oi.Quantity)
               .IsRequired();
    }
}