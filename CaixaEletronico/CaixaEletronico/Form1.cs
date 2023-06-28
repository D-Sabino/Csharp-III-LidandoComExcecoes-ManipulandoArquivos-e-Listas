using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        public Form1()
        {
            InitializeComponent();
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            int numeroDaConta;
            numeroDaConta = 1;

            double saldo = 100.0;
            double valor = 10.0;
            bool podeSacar = (valor <= saldo) && (valor >= 0) ;

            if (podeSacar )
            {
                double saldoAposSaque = saldo - valor;

                MessageBox.Show("O saldo foi realizado com sucesso!");
                MessageBox.Show("O saldo atual é: " + saldoAposSaque);
            } else
            {
                MessageBox.Show("Saldo insuficiente");
            }

                

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Carlos = 64;
            int Maria = 64;
            int Daniel = 25;
            int media = (Carlos + Maria + Daniel) / 3;
            MessageBox.Show("A media das idades é: " + media);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c;
            double delta, a1, a2;

            a = 2;
            b = 5;
            c = 2;

            delta = b * b - 4 * a * c;
            a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("A1 = " + a1 + "\nA2 = " + a2);

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int idade = 25;
            bool brasileira = true;

            if (brasileira && idade >= 16)
            {
                MessageBox.Show("Você pode votar!");
            } else if (idade < 16)
            {
                MessageBox.Show("Você precisa ter mais de 16 anos para votar!");
            }
            else
            {
                MessageBox.Show("Você precisa ser um cidadão brasileiro para votar!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 100;
            double imposto;

            if (valorDaNotaFiscal < 1000)
            {
                imposto = valorDaNotaFiscal * 0.02;
                MessageBox.Show("O imposto sera de " + imposto);
            }
            else if (valorDaNotaFiscal >= 1000 && valorDaNotaFiscal < 3000)
            {
                imposto = valorDaNotaFiscal * 0.025;
                MessageBox.Show("O imposto sera de " + imposto);
            }
            else if (valorDaNotaFiscal >= 3000 && valorDaNotaFiscal < 7000)
            {
                imposto = valorDaNotaFiscal * 0.028;
                MessageBox.Show("O imposto sera de " + imposto);
            }
            else if (valorDaNotaFiscal >= 7000)
            {
                imposto = valorDaNotaFiscal * 0.03;
                MessageBox.Show("O imposto sera de " + imposto);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double valorInvestido = 2000.0;

            for (int i = 1; i <= 12; i++)
            {
                valorInvestido *= 1.01;
            }

            int i = 1;
            while (i <= 12)
            {
                valorInvestido *= 1.01;
                i++;
            }

            MessageBox.Show("O valor investido agora é: " + valorInvestido);


        }

        private void button7_Click(object sender, EventArgs e)
        {

            String texto = "";

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    texto = texto + ", " + i.ToString();
                }
            }

            MessageBox.Show("Os números múltiplos de 3 são: " + texto);



        }

        private void button8_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = fatorial * n;
                MessageBox.Show("fatorial(" + n + ") = " + fatorial);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string serieFibonacci = "";
            int anterior = 0;
            int atual = 1;
            while (atual <= 100)
            {
                serieFibonacci += atual + " ";
                int proximo = anterior + atual;
                anterior = atual;
                atual = proximo;
            }
            MessageBox.Show("A série de Fibonacci até 100: " + serieFibonacci);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int qtdLinhas = 5;
            string triangulo = "";
            for (int linha = 1; linha <= qtdLinhas; linha++)
            {
                for (int coluna = 1; coluna <= linha; coluna++)
                {
                    triangulo += (linha * coluna) + " ";
                }
                triangulo += "\n";
            }
            MessageBox.Show(triangulo);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int numero = 15;
            
            if (numero % 3 == 0)
            {
                MessageBox.Show("O numero " + numero + " é divisivel por 3!");
            }else if (numero % 4 == 0)
            {
                MessageBox.Show("O numero " + numero + " é divisivel por 4!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            String texto_3 = "";
            String texto_4 = "";

            for (int i = 0; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    texto_3 = texto_3 + ", " + i.ToString();
                } else if (i % 4 == 0){
                    texto_4 = texto_4 + ", " + i.ToString();
                }
            }

            MessageBox.Show("Os números múltiplos de 3 são: " + texto_3);
            MessageBox.Show("Os números múltiplos de 4 são: " + texto_4);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    soma += i;
                }
            }

            MessageBox.Show("Total: " + soma);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Conta umaConta = new Conta();
            umaConta.numero = 1;
            umaConta.titular = "Joaquim";
            umaConta.saldo = 2000.0;

            Conta outraConta = new Conta();
            outraConta.numero = 2;
            outraConta.titular = "Silva";
            outraConta.saldo = 1500.0;

            //MessageBox.Show("O titular da conta " + umaConta.numero + " é " + umaConta.titular);

            Conta guilherme = new Conta();
            Conta mauricio = new Conta();

            guilherme.saldo = 1500.0;
            mauricio.saldo = 2000.0;

            guilherme.Transfere(200.0, mauricio);

            //MessageBox.Show("O saldo da conta guilherme é " + guilherme.saldo);
            //MessageBox.Show("O saldo da conta mauricio é " + mauricio.saldo);


            Conta conta = new Conta();
            Cliente cliente = new Cliente();

            conta.cliente = cliente;
            cliente.Nome = "Victor"; //outra forma: conta.cliente.nome = ...
            conta.cliente.RgTitular = "12345678-9"; //outra forma: cliente.rgtitular = ...

            MessageBox.Show(conta.cliente.Nome);


        }

        private void button15_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente("Daniel Sabino");

        }
        
        private Conta conta;
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            this.conta = new Conta();
            this.conta.Titular = "Victor";
            this.conta.Numero = 1;
            this.conta.Deposita(250.0);

            this.MostraConta();
            

            contas = new Conta[2];
            contas[0] = new Conta();
            contas[0].Numero = 1;
            contas[0].Titular = "Daniel";

            contas[1] = new Conta();
            contas[1].Numero = 2;
            contas[1].Titular = "Bianca";

            foreach(Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular);
                destinoDaTransferencia.Items.Add(conta.Titular);
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            string textoDoValorDoDeposito = textoValor.Text;
            double valorDeposito;

            if (double.TryParse(textoDoValorDoDeposito, out valorDeposito))
            {
                this.conta.Deposita(valorDeposito);
                this.MostraConta();
            }
            else
            {
                // Tratar o erro de conversão aqui, como exibir uma mensagem de erro para o usuário
                MessageBox.Show("Ocorreu um erro de conversao");
            }
            

            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposita(1000);
            cp.Saca(100);

            MessageBox.Show("Saldo Poupanca " + cp.Saldo);

            Conta c = new Conta();
            c.Deposita(100);
            c.Saca(50);

            MessageBox.Show("Saldo Corrente " + c.Saldo);
            

            Conta c1 = new Conta();
            c1.Deposita(10);

            ContaPoupanca c2 = new ContaPoupanca();
            c2.Deposita(40);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(c1);
            t.Adiciona(c2);

            MessageBox.Show("O total é: " + t.Total);
           

            ContaCorrente c1 = new ContaCorrente();
            ContaCorrente c2 = new ContaCorrente();

            c1.Deposita(10);
            c2.Deposita(40);

            TotalizadorDeContas t = new TotalizadorDeContas();
            t.Adiciona(c1);
            t.Adiciona(c2);

            MessageBox.Show("O total é: " + t.Total);
             */
            /*
                O C# sabe que ContaCorrente herda todos os atributos e métodos de Conta, 
                e portanto tem a certeza que existe o atributo Saldo, 
                e que ele poderá invocá-lo sem maiores problemas!
            

            Conta[] contas = new Conta[2];
            contas[0] = new Conta();
            contas[1] = new ContaPoupanca();

            contas[0].Deposita(10);
            contas[1].Deposita(100);

            foreach(Conta conta in contas)
            {
                MessageBox.Show("O saldo da conta é: " + conta.Saldo);
            }
            

            ContaCorrente contaCorrente = new ContaCorrente();
            ContaPoupanca contaPoupanca = new ContaPoupanca();

            contaCorrente.Deposita(100);
            contaPoupanca.Deposita(100);

            contaCorrente.Saca(10);
            MessageBox.Show("O saldo da conta é: " + contaCorrente.Saldo);
            

            ContaPoupanca cp = new ContaPoupanca();
            ContaInvestimento ci = new ContaInvestimento();
            TotalizadorDeTributos t = new TotalizadorDeTributos();
            GerenciadorDeImposto g = new GerenciadorDeImposto();
            ContaCorrente contaCorrente = new ContaCorrente();


            cp.Deposita(10);
            ci.Deposita(100);

            t.Acumula(cp);
            t.Acumula(ci);

            MessageBox.Show("Tributos: " + t.Total);

            g.Adiciona(contaCorrente);
            

            ContaCorrente c = new ContaCorrente();
            ContaCorrente c2 = new ContaCorrente();
            MessageBox.Show("Total de contas correntes: " + ContaCorrente.TotalDeContas);
            MessageBox.Show("Proximo numero: " + ContaCorrente.ProximoNumero());
            */

            ContaCorrente conta = new ContaCorrente();

            double valorSaque = Convert.ToDouble(textoValor.Text);
            try
            {
                conta.Saca(valorSaque);
                MessageBox.Show("Dinheiro liberado");
            }
            catch(SaldoInsuficienteException exception)
            {
                MessageBox.Show("Saldo Insuficiente");
    
            }
            catch(ArgumentException exception)
            {
                MessageBox.Show("Valor invalido para o saque");
            }
        }

        private void MostraConta()
        {
            /*
            textoNumero.Text = Convert.ToString(this.conta.Numero);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            textoTitular.Text = this.conta.Titular;
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            string textoDoValorDoSaque = textoValor.Text;
            double valorSaque;

            if (double.TryParse(textoDoValorDoSaque, out valorSaque))
            {
                this.conta.Saca(valorSaque);
                this.MostraConta();
            }
            else
            {
                // Tratar o erro de conversão aqui, como exibir uma mensagem de erro para o usuário
                MessageBox.Show("Ocorreu um erro de conversao");
            }
            */
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            textoTitular.Text = contaSelecionada.Titular;
            textoNumero.Text = Convert.ToString(contaSelecionada.Numero);
            textoSaldo.Text = Convert.ToString(contaSelecionada.Saldo);
        }

        private void buttonDeposito_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            if (indiceSelecionado != null)
            {
                contaSelecionada.Deposita(Convert.ToDouble(textoValor.Text));
            }
        }

        private void buttonSaque_Click(object sender, EventArgs e)
        {
            int indiceSelecionado = comboContas.SelectedIndex;
            Conta contaSelecionada = contas[indiceSelecionado];

            if (indiceSelecionado != null)
            {
                contaSelecionada.Saca(Convert.ToDouble(textoValor.Text));
            }
        }

        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            int indiceComboContasSelecionado = comboContas.SelectedIndex;
            int indiceDestinoDaTransferenciaSelecionado = destinoDaTransferencia.SelectedIndex;

            Conta contaOrigem = contas[indiceComboContasSelecionado];
            Conta contaDestino = contas[indiceDestinoDaTransferenciaSelecionado];

            if (indiceComboContasSelecionado != null && indiceDestinoDaTransferenciaSelecionado != null)
            {
                contaOrigem.Transfere(Convert.ToDouble(textoValor.Text), contaDestino);
            }

        }
    }
}
