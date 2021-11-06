using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.DTO
{
    class FormandoDTO
    {
        private int _cpf;
        private string _nome;
        private string _local;

        public int Cpf { get => _cpf; set => _cpf = value; }
        public string Nome { get => _nome; set => _nome = value; }
        public string Local { get => _local; set => _local = value; }
    }
}
