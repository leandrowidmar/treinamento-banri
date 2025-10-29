using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace banrisul
{
    
    internal class ExercicioEncapsulamento
    {
        static void Main()
        {

            ContaBancaria contaJohn = new ContaBancaria("148.578.595-25", "John Doe");

            // 2. TENTANDO ACESSAR OS CAMPOS DIRETAMENTE (Vai dar erro!)
            // Eu comentei essas linhas, porque elas DEVEM dar erro.
            // O seu encapsulamento (os 'private') está funcionando!

            // contaJohn.Numero = 25; // Erro! (Correto, pois é 'private')
            // contaJohn.Titular = "Mary Monroe"; // Erro! (Correto, pois é 'private')
            // contaJohn.Saldo = 1000000; // Erro! (Correto, pois é 'private')


            // --- CONSERTEI AQUI ---
            // O Main precisa usar os "Porteiros" (Getters) para LER os dados.
            Console.WriteLine($"Conta {contaJohn.GetNumeroConta()} em nome de {contaJohn.GetTitular()}: Saldo de {contaJohn.GetSaldo()}.");

            // 3. USANDO OS "COMPORTAMENTOS"
            contaJohn.Depositar(100);

            Console.WriteLine($"Saque de R$ 30,00 {(contaJohn.Sacar(30) ? "bem sucedido!" : "Não foi concluído.")}"); // Deve ser Bem sucedido.
            Console.WriteLine($"Saque de R$ 100,00 {(contaJohn.Sacar(100) ? "bem sucedido!" : "Não foi concluído.")}"); // Deve ser Não concluído.

            // 4. VERIFICANDO O SALDO FINAL
            Console.WriteLine($"Conta {contaJohn.GetNumeroConta()} em nome de {contaJohn.GetTitular()}: Saldo de {contaJohn.GetSaldo()}.");
        }
    }

    // --- CONSERTEI AQUI ---
    // Esta é a "Planta Baixa" da Conta Bancária.
    // Agora é UMA classe só, com todas as características dentro dela.
    public class ContaBancaria
    {
        // 1. CARACTERÍSTICAS (Os "Cofres" privados)
        // (O exercício pedia 'Numero' e 'CPF' como Somente Leitura)
        private string _numeroConta;
        private string _cpf;
        private string _titular;
        private double _saldo; // 'double' é melhor para dinheiro


        // 2. CONSTRUTOR
        // (É chamado quando você usa 'new ContaBancaria(...)')
        public ContaBancaria(string cpf, string titular)
        {
            _cpf = cpf;
            _titular = titular;

            // --- ADICIONEI ISSO ---
            _saldo = 0; // Toda conta nova começa com saldo 0

            // Apenas um número de conta aleatório por enquanto
            _numeroConta = "12345-6";
        }


        // 3. "PORTEIROS" (Getters - Para o Main poder LER os dados)

        // Você já tinha feito este, estava perfeito!
        public string GetNumeroConta()
        {
            return _numeroConta;
        }

        // --- ADICIONEI ISSO ---
        // Criei os outros getters que o Main precisava para ler
        public string GetTitular()
        {
            return _titular;
        }

        public double GetSaldo()
        {
            return _saldo;
        }

        // (Note que NÃO fizemos "Setters" públicos, por isso o Main não pode alterar!)


        // 4. COMPORTAMENTOS (Os métodos de negócio)

        // --- ADICIONEI ISSO (Vazio) ---
        // O Main chama 'Depositar', então o método precisa existir.
        // O exercício pede para não aceitar valores menores que 0.
        public void Depositar(double valor)
        {
            // SUA PRÓXIMA MISSÃO:
            // 1. Verifique se 'valor' é maior que 0
            // 2. Se for, adicione o 'valor' ao '_saldo'
        }

        // --- ADICIONEI ISSO (Vazio) ---
        // O Main chama 'Sacar', então o método precisa existir.
        // O exercício pede para não deixar o saldo negativo e retornar 'true' ou 'false'.
        public bool Sacar(double valor)
        {
            // SUA PRÓXIMA MISSÃO:
            // 1. Verifique se você TEM saldo suficiente (se _saldo >= valor)
            // 2. Se tiver, subtraia o 'valor' do '_saldo' e retorne 'true'
            // 3. Se não tiver, não faça nada e retorne 'false'

            return false; // Retorno temporário
        }
    }
}