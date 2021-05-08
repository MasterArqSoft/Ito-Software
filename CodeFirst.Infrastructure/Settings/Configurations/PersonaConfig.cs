using CodeFirst.Domain.Entities;
using CodeFirst.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CodeFirst.Infrastructure.Settings.Configurations
{
    public class PersonaConfig : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Personas");

            builder.HasKey(c => c.PersonaId);

            builder.Property(c => c.PersonaId)
                   .HasColumnName("PersonaId")
                   .HasColumnType<int>("int")
                   .HasComment("Identificador de la persona")
                   .IsRequired();


            builder.Property(c => c.NumeroDocumento)
                   .HasColumnName("NumeroDocumento")
                   .HasColumnType("nvarchar(50)")
                   .HasComment("Nombre de la persona")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(c => c.Nombres)
                   .HasColumnName("Nombre")
                   .HasColumnType("nvarchar(50)")
                   .HasComment("Nombre de la persona")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(c => c.Apellidos)
                   .HasColumnName("Apellido")
                   .HasColumnType("nvarchar(50)")
                   .HasComment("Apellido de la persona")
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(c => c.TipoDocumentoId)
                   .HasColumnName("TipoDocumento")
                   .HasColumnType("nvarchar(50)")
                   .HasComment("Tipo de documento")
                   .HasMaxLength(15)
                   .HasConversion(
                                   x => x.ToString(),
                                   x => (TipoDocumento)Enum.Parse(typeof(TipoDocumento), x)
                                 )
                   .IsRequired();

            builder.Property(c => c.DepartamentoId)
                   .HasColumnName("DepartamentoId")
                   .HasColumnType("int")
                   .HasComment("Identificador del departamento")
                   .IsRequired();
        }
    }
}
