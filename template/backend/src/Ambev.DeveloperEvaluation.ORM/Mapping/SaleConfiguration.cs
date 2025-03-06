using Ambev.DeveloperEvaluation.Domain.Aggregates.Sale;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ambev.DeveloperEvaluation.ORM.Mapping
{
    public class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {            
            builder.ToTable("Sales");

            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).HasColumnType("uuid").HasDefaultValueSql("gen_random_uuid()");

            builder.Property(u => u.SaleNumber).IsRequired().UseIdentityColumn();
            builder.Property(u => u.TotalSaleAmount).IsRequired();
            builder.Property(u => u.CustomerName).IsRequired();
            builder.Property(u => u.BranchName).IsRequired();
            builder.Property(u => u.SaleStatus).IsRequired();
        }
    }
}
