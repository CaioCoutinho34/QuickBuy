using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repostorios.Configuracao
{
    public class PedidoConfig : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(ped => ped.Id);
            builder
               .Property(ped => ped.UsuarioId)
                .IsRequired();
            builder
                .Property(ped => ped.DataPedido);

            builder
               .Property(ped => ped.FormaPagamentoId);
            builder
               .Property(ped => ped.CEP);

            builder
               .Property(ped => ped.Estado)
                .HasMaxLength(100);

            builder
               .Property(ped => ped.Cidade)
            .HasMaxLength(100);

            builder
               .Property(ped => ped.EnderecoCompleto)
            .HasMaxLength(100);

            builder
               .Property(ped => ped.NumeroEndereco);
            builder
             .HasOne(ped => ped.Usuario);

        }
    }
}
