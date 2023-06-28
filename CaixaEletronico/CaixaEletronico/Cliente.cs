using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Cliente
    {
        public string Nome { get; set; }
        public string RgTitular { get; set; }
        public string cpf;
        public string Endereco { get; set; }
        public int idade;

        public Cliente(string nome)
        {
            this.Nome = nome;
        }

        public bool EhMaiorDeIdade()
        {
            if (this.idade >= 18)
                return true;
            else
                return false;
        }

        public bool PodeAbrirConta()
        {
            var maiorDeIdade = (this.idade >= 18);
            //var emancipado = (this.EEmancipado);
            var temCpf = !string.IsNullOrEmpty(this.cpf);

            return (maiorDeIdade) && temCpf;
        }
    }
}
