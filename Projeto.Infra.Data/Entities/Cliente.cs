﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Entities
{
	public class Cliente
	{

		public int IdCliente { get; set; }
		public string Nome { get; set; }
		public string Telefone{ get; set; }
		public DateTime DataCriacao { get; set; }
		public string Nota { get; set; }


	}
}
