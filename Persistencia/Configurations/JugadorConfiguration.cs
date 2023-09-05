using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Data.Configuration
{
    public class JugadorConfiguration : IEntityTypeConfiguration<Jugador>
    {
        public void Configure(EntityTypeBuilder<Jugador> builder)
        {
            // Aquí puedes configurar las propiedades de la entidad Marca
            // utilizando el objeto 'builder'.
            builder.ToTable("jugador");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(p=> p.Dorsal)
            .IsRequired()
            .HasColumnType("int")
            .HasMaxLength(5);
        
            builder.HasOne(p => p.Posicion)
            .WithMany(p => p.Jugadores)
            .HasForeignKey(p => p.IdPosFk);
        }
    }
}