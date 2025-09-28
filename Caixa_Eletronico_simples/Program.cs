using Caixa_Eletronico_simples.Classe;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Caixa_Eletronico_simples
{
    internal class Program
    {
        static void Main(string[] args)
        // Define um metodo para exibir o menu de opções ao usuário.
        {
            void MostrarOpcoes()
            {
                Console.WriteLine("Por Favor selecione uma das Opções...");
                Console.WriteLine("1. Deposito");
                Console.WriteLine("2. Saque");
                Console.WriteLine("3. Saldo");
                Console.WriteLine("4. Sair");

            }
            // Define o método para realzar um depósito na conta do usuário.

            void deposito(TitularCartao usuario)
            {
                Console.WriteLine("Valor do Deposito: ");
                // Lê o valor do depósito informado pelo usuário e o converte para double
                double Deposito = double.Parse(Console.ReadLine());
                // Adiciona o valor do depósito ao saldo atual do usuário.
                usuario.Saldo = usuario.Saldo + Deposito;
                Console.WriteLine("Saldo atual:" + usuario.Saldo);
            }
            // Define o método para realzar um saque na conta do usuário.
            void saque(TitularCartao usuario)
            {
                Console.WriteLine("Valor do saque: ");
                //Lê o valor do saque informado pelo usuário.
                double Saque = double.Parse(Console.ReadLine());
                //Verifica de o saldo é suficiente para o saque.
                if (usuario.Saldo < Saque)
                {

                    Console.WriteLine("Saldo insuficiente: ");

                }
                else
                {
                    // Subtrai o valor do saque do saldo do usuário.
                    usuario.Saldo = usuario.Saldo - Saque;
                    Console.WriteLine("Operação realizada!");
                }

            }
            // Define o método para exibir o saldo atual na conta do usuário.
            void saldo(TitularCartao usuario)
            {
                Console.WriteLine("Saldo Atual: " + usuario.Saldo);
            }

            // Cria uma lista para armazenar os dados dos titulares dos cartões.
            // Simula um mini banco de dados para testar o codigo.

            List<TitularCartao> titularCartao = new List<TitularCartao>();
            // Adiciona titlares de cartão à lista com seus dados
            //(número do cartão, senha, nome, sobrenome, valor em conta
            titularCartao.Add(new TitularCartao("1234567812345678", 12345, "Antonio", "Margaret", 1500.00));
            titularCartao.Add(new TitularCartao("8765432187654321", 54321, "Domic", "Decoco", 500.00));
            titularCartao.Add(new TitularCartao("2444666668888888", 11223, "Finn", "Murfyn", 50.00));
            titularCartao.Add(new TitularCartao("8888888666664442", 3221, "Jack", "Dog", 100000.00));

            Console.WriteLine("Bem vindo!");
            Console.WriteLine("Por Favor Insira o seu cartão");
            // Declara uma string para armazenar o número do cartão inserido.
            String numCartaoDeb = "";
            // Declara uma variável para armazenar os dados do usuário atual.
            TitularCartao usuarioatual;

            // Inicia um loop infinito para solicitar e validar o número do cartão.
            while (true)
            {

                try
                {
                    // lê o númerodo cartão inserido pelo usuarío.
                    numCartaoDeb = Console.ReadLine();
                    // Procura na lista um titular com o número do cartão correspondete.
                    usuarioatual = titularCartao.FirstOrDefault(a => a.NumCartao == numCartaoDeb);
                    // Se um usuário for encontrado, o loop é interrompido.
                    if (usuarioatual != null) { break; }
                    // Se não for encontrado, exibe uma mensagem de erro.
                    else { Console.WriteLine("Cartão não reconhecido, por favor tente novamente."); }

                }
                // Captura exceções genéricas e exibe uma mensagem de erro.
                catch { Console.WriteLine("Cartão não reconhecido, por favor tente novamente."); }


            }
            Console.WriteLine("Digite a senha: ");
            // Declara uma varíavel para armazenar a senha inserida.
            int SenhaUsuario = 0;
            // Inicia um loop infinito para solicitar e validar a senha.
            while (true)
            {

                try
                {
                    // Lê a senha inserida e a converte para inteiro
                    SenhaUsuario = int.Parse(Console.ReadLine());
                    // Verifica se a senha inserida corresponde à senha do usuário atual
                    // Se a senha for a correta, interrompe o looping.
                    if (usuarioatual.Senha == SenhaUsuario) { break; }
                    else { Console.WriteLine("Senha Incorreta, por favor tente novamente."); }

                }
                // Captura exceções genéricas e exibe uma mensagem de erro.
                catch { Console.WriteLine("Senha Incorreta, por favor tente novamente."); }



            }
            // Exibi uma mensagem de boas-vindas para o usuário autenticado.
            Console.WriteLine("Bem vindo " + usuarioatual.Nome + "!");
            // Inicializa a variável de opções do menu.
            int opcoes = 0;

            // Inicia um loop do-while que continuará até que o usuário esolha a opção sair.
            do
            {
                // Mostra o menu de opções.
                MostrarOpcoes();
                try
                {
                    // Lê a opção escolhida pelo usuário.
                    opcoes = int.Parse(Console.ReadLine());
                }
                // Captura exceções caso a entrada não seja um número.
                catch { }
                // Verifica a opção escolhida e chama o método correspondente.
                if (opcoes == 1)
                {
                    deposito(usuarioatual);
                }
                else if (opcoes == 2)
                {
                    saque(usuarioatual);

                }
                else if (opcoes == 3)
                {

                    saldo(usuarioatual);
                }
                else if (opcoes == 4)
                {
                    // Interompe o looping se o usuário escolher sair.
                    break;
                }
                else
                {
                    // Reseta a variável de opções se uma opção inválida for incerida.
                    opcoes = 0;

                }



            }
            while (opcoes != 4);
            // Exibe uma menssagem de encerramneto após o fim do loop.
            Console.WriteLine("Operação encerrada.");



        }
    }
}
