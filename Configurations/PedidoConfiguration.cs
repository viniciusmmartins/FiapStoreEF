using FiapStore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FiapStoreEF.Configurations
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("Pedido");
            builder.HasKey(p => p.Id);
            builder.Property(u => p.Id)
            .HasColumnType("INT").ValueGeneratedNever().UseIdentityColumn();
            builder.Property(p => p.NomeProduto).HasColumnType("VARCHAR(100)");
            builder.HasMany(p => p.Usuario)
                .WithMany(u => u.Pedido)
                .HasForeignKey(u => u.Id);
        }
    }
}
