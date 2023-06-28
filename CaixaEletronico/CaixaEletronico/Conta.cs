using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    abstract class Conta
    {
        public int Numero { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; protected set; }
        private int agencia;
        public int Tipo { get; set; }

        public Cliente cliente;

        public abstract void Saca(double valorASerSacado);
        /*
        {

            this.Saldo -= valorASerSacado;
            
            /*
            if (this.Saldo >= valorASerSacado && valorASerSacado >= 0)
            {
                if (this.cliente.EhMaiorDeIdade())
                {
                    this.Saldo -= valorASerSacado;
                    return true;
                }
                else if (valorASerSacado <= 200)
                {
                    this.Saldo -= valorASerSacado;
                    return true;
                }
                else
                    return false;
            }
            else
                return false;
            
        }
        */

        public virtual void Deposita(double valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }

    }
}
