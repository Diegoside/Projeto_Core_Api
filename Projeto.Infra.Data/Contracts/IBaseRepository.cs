using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contracts
{
	
        public interface IBaseRepository<T>
            where T : class
		{
			void Inserir(T obj);
			void Alterar(T obj);
			void Excluir(T obj);
			List<T> Consultar();
			T ObterPorId(int id);
		}

}

