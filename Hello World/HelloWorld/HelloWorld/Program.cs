using System;
using System.Transactions;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //******* OPERADORES ARITMETICOS *******
            Console.WriteLine("**********OPERADORES ARITMETICOS*******");
            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 5;
            var divisao = 10 / 5;
            var mod = 10 % 5;
            Console.WriteLine($"Resultado soma: {soma}");
            Console.WriteLine($"Resultado subtração: {subtracao}");
            Console.WriteLine($"Resultado multiplicação: {multiplicacao}");
            Console.WriteLine($"Resultado divisão: {divisao}");
            Console.WriteLine($"Resultado resto divisão: {mod}");
            Console.WriteLine();


            //******* OPERADORES LÓGICOS ********
            Console.WriteLine("******* OPERADORES LOGICOS / AND *******");
            // AND
            var AndVerdadeiro = true && true;
            var AndFalso1 = true && false;
            var AndFalso2 = false && true;
            var AndFalso3 = false && false;
            Console.WriteLine(AndVerdadeiro);
            Console.WriteLine(AndFalso1);
            Console.WriteLine(AndFalso2);
            Console.WriteLine(AndFalso3);
            Console.WriteLine();
            // OR
            Console.WriteLine("******* OPERADORES LOGICOS / OR *******");
            var OrVerdadeiro1 = true && true;
            var OrVerdadeiro2 = true && false;
            var OrVerdadeiro3 = false && true;
            var OrFalso = false && false;
            Console.WriteLine(OrVerdadeiro1);
            Console.WriteLine(OrVerdadeiro2);
            Console.WriteLine(OrVerdadeiro3);
            Console.WriteLine(OrFalso);
            Console.WriteLine();



            // NOT 
            Console.WriteLine("******* OPERADORES LOGICOS / NOT *******");
            var falsoNegado = !OrFalso;
            var verdadeiroNegado = !AndVerdadeiro;
            Console.WriteLine(falsoNegado);
            Console.WriteLine(verdadeiroNegado);
        
        }
    }
}
