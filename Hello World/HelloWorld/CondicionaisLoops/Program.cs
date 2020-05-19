using System;

namespace CondicionaisLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a sua idade:");
            int.TryParse(Console.ReadLine(), out int idade);

            if(idade < 12)
            {
                Console.WriteLine("Você é uma criança");
            } else if(idade >= 12 && idade < 18)
            {
                Console.WriteLine("Você é um adolecente");
            }
            else
            {
                Console.WriteLine("Você é um adulto");
            }

            string mensagem = idade >= 18 ? "Você é maior de idade" : "Você é menor de idade";
            Console.WriteLine(mensagem);
        } 
    }
}
