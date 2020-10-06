using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(f => f.IdFornecedor);

            builder.Property(f => f.IdFornecedor).HasColumnName("IdFornecedor").IsRequired();

            builder.Property(f => f.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(150);

            builder.Property(f => f.Cnpj).HasColumnName("Cnpj").IsRequired().HasMaxLength(25);

        }
    }
}
