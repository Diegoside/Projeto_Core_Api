using Microsoft.EntityFrameworkCore;
using Projeto.Infra.Data.Context;
using Projeto.Infra.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        //atributo
        private readonly SqlServerContext context;

        //construtor para injeção de dependência
        public BaseRepository(SqlServerContext context)
        {
            this.context = context;
        }

        public void Inserir(T obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges(); //executando
        }

        public void Alterar(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges(); //executando
        }

        public void Excluir(T obj)
        {
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges(); //executando
        }

        public List<T> Consultar()
        {
            return context.Set<T>().ToList();
        }

        public T ObterPorId(int id)
        {
            return context.Set<T>().Find(id);
        }
    }
}
