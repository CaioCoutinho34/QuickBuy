using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repostorios.Configuracao
{
    public class FormaPagamentoConfig : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(fomr => fomr.Id);
            builder
               .Property(fomr => fomr.Descricao)
                .HasMaxLength(100);
            builder
              .Property(fomr => fomr.Nome)
               .HasMaxLength(50)
               .IsRequired();
        }
    }
}
