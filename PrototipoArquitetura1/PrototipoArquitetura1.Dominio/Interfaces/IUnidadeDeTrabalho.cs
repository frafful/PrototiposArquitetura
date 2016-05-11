using PrototipoArquitetura1.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Dominio.Interfaces
{
    public interface IUnidadeDeTrabalho : IDisposable
    {
        IDbConnection Conexao { get; }
        IDbTransaction Trans { get; }
        void BeginTran();
        void Rollback();
        void Commit();
    }
}
