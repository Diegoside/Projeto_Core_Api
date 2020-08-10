using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Projeto.Presentation.Api.Models
{
	public class ClienteConsultaModel
	{
		public int IdCliente { get; set; }
		public string Nome { get; set; }
		public string Email { get; set; }
		public string Telefone { get; set; }
		public DateTime DataCriacao { get; set; }
	}
}