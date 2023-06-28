using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    class SeguroDeVida: Conta, Tributavel
    {
        public override void Saca(double valor)
        {
            this.Saldo -= valor;
        }

        public double CalculaTributo()
        {
            return this.Saldo -= 42;
        }
    }
}
