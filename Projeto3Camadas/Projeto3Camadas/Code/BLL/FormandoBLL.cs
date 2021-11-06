using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Projeto3Camadas.Code.DTO;
using Projeto3Camadas.Code.DAL;

namespace Projeto3Camadas.Code.BLL
{
    class FormandoBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_nome";

        public void Inserir (FormandoDTO forDto)
        {
            string inserir = $"insert into {tabela} values (null, '{forDto.Nome}','{forDto.Local}') ";
            conexao.ExecutarComando(inserir);
        }

        private void Editar(FormandoDTO forDto)
        {

        }

        private void Excluir(FormandoDTO forDto)
        {

        }

        private void Listar()
        {

        }
    }
}
