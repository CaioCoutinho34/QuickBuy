using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repostorios.Configuracao
{
    public class ProdutoConfig : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(prod => prod.Id);

            builder
               .Property(prod => prod.Nome)
               .IsRequired()
               .HasMaxLength(50);
            builder
              .Property(prod => prod.Descricao)
              .HasMaxLength(400);
            builder
              .Property(prod => prod.Preco)
              .IsRequired();
           
        }
    }
}
