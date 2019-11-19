using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repostorios.Configuracao
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(usu => usu.Id);

            ///Builder utiliza o padrao fluenti
            builder
                .Property(usu => usu.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(usu => usu.Email)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(usu => usu.Nome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(usu => usu.SobreNome)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(usu => usu.Senha)
                .IsRequired()
                .HasMaxLength(400);
            builder
                .HasMany(usu => usu.Pedidos)
                .WithOne(p=> p.Usuario);
            
        }
    }
}
