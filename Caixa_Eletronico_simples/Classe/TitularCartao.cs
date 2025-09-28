using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Caixa_Eletronico_simples.Classe
{
    // Define a classe TitularCartao para armazenar os dados de cada cliente.
    public class TitularCartao
    {
        // Propriedade para armazenar o número do cartão.
        public string NumCartao { get; set; }
        // Propriedade para armazenar a senha do cartão.
        public int Senha {  get; set; }
        // Propriedade para armazenar o primeiro nome do titular
        public string Nome {  get; set; }
        // Propriedade para armazenar o sobrenome do titular 
        public string Sobrenome { get; set; }
        // Propriedade para armazenar o saldo disponível na conta
        public double Saldo { get; set; }

        // Este é o construtor da classe. Ele é chamado quando um novo objeto TitularCartao é criado.
        public TitularCartao(string NumCartao, int Senha, string Nome, string Sobrenome, double Saldo) 
        {

            // 'this' se refere à instância atual do objeto.
            // Aqui, atribuímos os valores passados para o construtor às propriedades do objeto.
            this.NumCartao = NumCartao;
            this.Senha = Senha;
            this.Nome = Nome;
            this.Sobrenome = Sobrenome;
            this.Saldo = Saldo;



        }
        

    }
}
