using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(p => p.IdProduto);

            builder.Property(p => p.IdProduto).HasColumnName("IdProduto").IsRequired();

            builder.Property(p => p.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(150);

            builder.Property(p => p.Preco).HasColumnName("Preco").IsRequired().HasColumnType("decimal(18,2)");

            builder.Property(p => p.Quantidade).HasColumnName("Quantidade").IsRequired();

            builder.HasOne(p => p.fornecedor).WithMany(f => f.Produtos).HasForeignKey(p => p.IdFornecedor);
        }
    }
}
