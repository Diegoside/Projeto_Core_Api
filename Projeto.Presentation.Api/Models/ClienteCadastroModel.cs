using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Presentation.Api.Models
{
	public class ClienteCadastroModel
	{

		[MinLength(3, ErrorMessage = "Informe no mínimo {1} caracteres.")]
		[MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
		[Required(ErrorMessage = "Informe o nome do cliente.")]
		public string Nome { get; set; }
		[EmailAddress(ErrorMessage = "Informe um endereço de email válido.")]
		[Required(ErrorMessage = "Informe o email do cliente.")]
		public string Email { get; set; }

		[Phone(ErrorMessage = "Informe um telefone válido")]
		[Required(ErrorMessage = "Informe seu Telefone")]
		public string Telefone { get; set; }


	}
}
