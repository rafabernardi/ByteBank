using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank
{
    public class Cliente
    {
        private String _cpf;

        public string Nome { get; set; }
        public String CPF
        {
            get
            {
                return _cpf;
            }
            set
            {
                // Escreva a validação do CPF
                _cpf = value;

            }
        }
        public String Profissao { get; set; }
    }
}
