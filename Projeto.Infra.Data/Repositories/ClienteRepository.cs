using Projeto.Infra.Data.Context;
using Projeto.Infra.Data.Contracts;
using Projeto.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
	public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
	{

		private readonly SqlServerContext context;
		//construtor para injeção de dependência
		public ClienteRepository(SqlServerContext context) : base(context)
		{
			this.context = context;
		}
	}
}
