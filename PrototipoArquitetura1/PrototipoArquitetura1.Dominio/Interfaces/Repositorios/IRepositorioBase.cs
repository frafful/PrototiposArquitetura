using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<T> where T : class
    {
        void Incluir(T entidade);

        void Incluir(T entidade, IDbTransaction trans);

        void Excluir(T entidade);

        void Excluir(T entidade, IDbTransaction trans);

        void Atualizar(T entidade);

        void Atualizar(T entidade, IDbTransaction trans);

        T ObterPorID(Int32 id);

        T ObterPorID(Int32 id, IDbTransaction trans);

        IEnumerable<T> Listar();

        IEnumerable<T> Listar(int indice, int quantidadeDeRegistros);

        IEnumerable<T> Listar(int indice, int quantidadeDeRegistros, IDbTransaction trans);
    }
}
