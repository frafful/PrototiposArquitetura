using PrototipoArquitetura1.Dominio.Interfaces;
using PrototipoArquitetura1.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Infra.Dados
{
    public class UnidadeDeTrabalho : IUnidadeDeTrabalho
    {
        private IDbConnection conexao;
        private IDbTransaction trans;

        public IDbConnection Conexao
        {
            get { return conexao; }
        }

        public IDbTransaction Trans
        {
            get { return trans; }
        }

        public UnidadeDeTrabalho()
        {
            conexao = new SqlConnection(ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        }

        public void BeginTran()
        {
            if (conexao.State == ConnectionState.Closed)
                conexao.Open();
            
            if (trans == null)
                trans = conexao.BeginTransaction();
            else
                throw new Exception("Já existe uma transação já aberta.");
        }

        public void Rollback()
        {
            if (trans != null)
                trans.Rollback();
            else
                throw new Exception("Não há transação aberta.");
        }

        public void Commit()
        {
            if (trans != null)
                trans.Commit();
            else
                throw new Exception("Não há transação aberta.");
        }

        public void Dispose()
        {
            if (conexao != null)
            {
                conexao.Close();
                conexao = null;
            }
        }
    }
}
