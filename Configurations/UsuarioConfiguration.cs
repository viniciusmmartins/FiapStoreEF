using FiapStore.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FiapStoreEF.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>

    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id)
            .HasColumnType("INT").ValueGeneratedNever().UseIdentityColumn();
            builder.Property(u => u.Nome).HasColumnType("VARCHAR(100)");
            builder.HasMany(u => u.Pedidos)
             .WithMany(p => p.Usuario)
             .HasForeignKey(p => p.UuarioId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
