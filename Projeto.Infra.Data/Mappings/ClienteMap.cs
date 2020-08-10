using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Mappings
{
	class ClienteMap : IEntityTypeConfiguration<Cliente>
	{
        public void Configure(EntityTypeBuilder<Cliente> builder)
		{
			builder.ToTable("Cliente");

			builder.HasKey(c => c.IdCliente);

			builder.Property(c => c.IdCliente)
                   .HasColumnName("IdCliente");

			//campos da tabela
			builder.Property(c => c.Nome)
                 .HasColumnName("Nome")
                 .HasMaxLength(150)
                  .IsRequired();
			
			builder.Property(c => c.Telefone)
                    .HasColumnName("Telefone")
                    .HasMaxLength(100)
                    .IsRequired();

			builder.Property(c => c.DataCriacao)
                   .HasColumnName("DataCriacao")
                   .IsRequired();

			builder.Property(c => c.Nota)
				 .HasColumnName("Nota")
				 .HasMaxLength(150);
				  

		}

	}
}
