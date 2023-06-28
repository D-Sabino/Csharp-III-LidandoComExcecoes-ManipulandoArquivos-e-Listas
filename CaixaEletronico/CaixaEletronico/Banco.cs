using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class Banco
    {/*
        private Conta[] contas;

        public Banco()
        {
            contas = new Conta[10]; // Inicializa o array de contas com 10 posições
        }

        public void Adiciona(Conta conta)
        {
            // Percorre o array para encontrar a primeira posição vazia
            for (int i = 0; i < contas.Length; i++)
            {
                if (contas[i] == null)
                {
                    contas[i] = conta;
                    break; // Encerra o loop ao encontrar a primeira posição vazia
                }
            }
        }*/

        private Conta[] contas = new Conta[10];

        private int quantidade;

        public void Adiciona(Conta conta)
        {
            this.contas[this.quantidade] = conta;
            this.quantidade++;
        }
    }
}
