using PrototipoArquitetura1.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using PrototipoArquitetura1.Dominio.Interfaces;
using PrototipoArquitetura1.Dominio.Abstratos;

namespace PrototipoArquitetura1.Infra.Dados.Repositorios
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : EntidadeBase
    {
        private UnidadeDeTrabalho contexto;

        public IUnidadeDeTrabalho UnidadeDeTrabalho
        {
            get
            {
                return (IUnidadeDeTrabalho)contexto;
            }
            set
            {
                contexto = (UnidadeDeTrabalho)value;
            }
        }

        public virtual void Incluir(T entidade)
        {
            UnidadeDeTrabalho.Conexao.Insert(entidade, contexto.Trans);
        }

        public virtual void Incluir(T entidade, IDbTransaction trans)
        {
            UnidadeDeTrabalho.Conexao.Insert(entidade, trans);
        }

        public virtual void Excluir(T entidade)
        {
            UnidadeDeTrabalho.Conexao.Delete(entidade);
        }
        public virtual void Excluir(T entidade, IDbTransaction trans)
        {
            UnidadeDeTrabalho.Conexao.Delete(entidade, trans);
        }

        public void Atualizar(T entidade)
        {
            UnidadeDeTrabalho.Conexao.Update(entidade);
        }

        public virtual void Atualizar(T entidade, IDbTransaction trans)
        {
            UnidadeDeTrabalho.Conexao.Update(entidade, trans);
        }

        public virtual T ObterPorID(Int32 id)
        {
            return UnidadeDeTrabalho.Conexao.Get<T>(id);
        }

        public virtual T ObterPorID(Int32 id, IDbTransaction trans)
        {
            return UnidadeDeTrabalho.Conexao.Get<T>(id, trans);
        }

        public virtual IEnumerable<T> Listar()
        {
            return UnidadeDeTrabalho.Conexao.GetList<T>();
        }

        public virtual IEnumerable<T> Listar(int indice, int quantidadeDeRegistros)
        {
            return UnidadeDeTrabalho.Conexao.GetListPaged<T>(indice, quantidadeDeRegistros, "", "ID Desc");
        }

        public virtual IEnumerable<T> Listar(int indice, int quantidadeDeRegistros, IDbTransaction trans)
        {
            return UnidadeDeTrabalho.Conexao.GetListPaged<T>(indice, quantidadeDeRegistros, "", "ID Desc", trans);
        }
    }
}
