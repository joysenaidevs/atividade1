using System;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada
	        // Ano atual
	        // Ano de nascimento


            // Processamento
	        // idade = ano atual - ano de nascimento
	        //     verificar se a idade é maior ou igual a 16

            // Saida
	        // Exibir mensagem
	        // voce pode votar caso a idade for maior ou igual a 16 caso contrario nao poderá votar


            //Entrada

            Console.WriteLine("Exercicio 1");

            Console.WriteLine("Digite o ano atual");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ano do seu nascimento");
            int anoNascimento = int.Parse(Console.ReadLine());

            //Processamento

            int idade = anoAtual - anoNascimento;
            Console.WriteLine(idade);

            //Saida
            
            if(idade>=16){
                Console.WriteLine("Voce pode ir votar!");

            }else{
                Console.WriteLine("Voce não pode ir votar!");
            }

        }
    }
}
