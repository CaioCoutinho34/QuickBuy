using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repostorios.Configuracao
{
    public class ItemPedidoConfig : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.HasKey(ItemPed => ItemPed.Id);

            builder
               .Property(ItemPed => ItemPed.ProdutoId)
               .IsRequired();
            builder
                .Property(ItemPed => ItemPed.Quantidade)
                .IsRequired();
      
        }
    }
}
