using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;
using System.Data;

namespace Projeto3Camadas.Code.BLL
{
    class FormandoBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_formando";

        public void Inserir (FormandoDTO forDto)
        {
            string inserir = $"insert into {tabela} values (null, '{forDto.Nome}','{forDto.Cpf}', '{forDto.Local}') ";
            conexao.ExecutarComando(inserir);
        }

        public void Editar(FormandoDTO forDto)
        {
            string alterar = $"update {tabela} set nome = '{forDto.Nome}', lugar = '{forDto.Local}' where cpf = '{forDto.Cpf}';";
            conexao.ExecutarComando(alterar);
        }

        public void Excluir(FormandoDTO forDto)
        {
            string excluir = $"delete from {tabela} where cpf = '{forDto.Cpf}';";
            conexao.ExecutarComando(excluir);
        }

        public DataTable Listar()
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }
    }
}
