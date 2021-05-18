using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ==========================
using System.Data;
using DTO;
using ConexaoSql;


namespace Regras_de_Negocios
{
    public class Negocios_Produtos
    {
        Conect conect = new Conect();

        public String Inserir(Produtos produtos)
        {
            try
            {
                conect.LimparParametros();
                conect.AddParametros("@Codigo", produtos.Codigo);
                conect.AddParametros("@Produto", produtos.Produto);
                conect.AddParametros("@Valor", produtos.Valor);               
                String IdProdutos = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_InserirProdutos").ToString();
                conect.FecharConexao();
                return IdProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String Alterar(Produtos produtos)
        {
            try
            {
                conect.LimparParametros();
                conect.AddParametros("@Codigo", produtos.Codigo);
                conect.AddParametros("@Produto", produtos.Produto);
                conect.AddParametros("@Valor", produtos.Valor);                
                String IdProdutos = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_AlterarProdutos").ToString();
                conect.FecharConexao();
                return IdProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public String Excluir(Produtos produtos)
        {
            try
            {
                conect.LimparParametros();
                conect.AddParametros("@Codigo", produtos.Codigo);
                String IdProdutos = conect.ExecutaManipulacao(CommandType.StoredProcedure, "Sp_ExcluirProdutos").ToString();
                conect.FecharConexao();
                return IdProdutos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Produtos_Colecao BuscarCodigo(long Codigo)
        {
            try
            {
                Produtos_Colecao Colecao = new Produtos_Colecao();
                conect.LimparParametros();
                conect.AddParametros("@Codigo", Codigo);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaProdutosCodigo");

                foreach (DataRow linhas in dt.Rows)
                {
                    Produtos produtos = new Produtos();
                    produtos.Codigo = Convert.ToInt64(linhas["Codigo"]);
                    produtos.Produto = Convert.ToString(linhas["Produto"]);
                    produtos.Valor = Convert.ToDecimal(linhas["Valor"]);                   
                    Colecao.Add(produtos);
                    conect.FecharConexao();

                }
                return Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Produtos_Colecao BuscaNome(String Produto)
        {
            try
            {
                Produtos_Colecao Colecao = new Produtos_Colecao();
                conect.LimparParametros();
                conect.AddParametros("@Produto", Produto);
                DataTable dt = conect.ExecutaConsulta(CommandType.StoredProcedure, "Sp_ConsultaProdutosNome");

                foreach (DataRow linhas in dt.Rows)
                {
                    Produtos produtos = new Produtos();
                    produtos.Codigo = Convert.ToInt64(linhas["Codigo"]);
                    produtos.Produto = Convert.ToString(linhas["Produto"]);
                    produtos.Valor = Convert.ToDecimal(linhas["Valor"]);                   
                    Colecao.Add(produtos);
                    conect.FecharConexao();

                }
                return Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
