using Microsoft.EntityFrameworkCore;
using Projeto.Infra.Data.Entities;
using Projeto.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Context
{
	class SqlServerContext : DbContext
	{

		public SqlServerContext(DbContextOptions<SqlServerContext> options): base(options)
		{

        }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			
			modelBuilder.ApplyConfiguration(new ClienteMap());
		}

		public DbSet<Cliente> Cliente { get; set; }

	}
}
