using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Runtime.InteropServices.ComTypes;

namespace Conversao
{
    class Program
    {
        static void Main(string[] args)
        {
            Programador dev = new Programador();
            dev.Nome = "Vitor Würdel";
            dev.AnosDeCarreira = 1;
            dev.ConheceMetodologiaAgil = true;
            dev.DataAdmissao = new DateTime(2020, 03, 02);
            dev.DataNascimento = new DateTime(1997, 09, 29);
            dev.Id = 1;
            dev.Linguagens = new List<string>() { "C#", "JS", "PY" };

            Funcionario funcionario = new Funcionario();

            funcionario.Nome = "Mateus";
            funcionario.DataAdmissao = new DateTime(2020, 03, 03);
            funcionario.DataAdmissao = new DateTime(1960, 03, 03);

            // ****** CONVERSÃO IMPLICITA ******

            int varInt = 20;
            long varLong = varInt;

            float varFloat = 10.5F;
            double varDouble = varFloat;

            char varChar = 't';
            int varInt1 = varChar;

            string meuTexto = $"Teste conversão inplicita" + $"de variavel inteira {varInt} e variavel float {varFloat}";
                
            Funcionario devfunc = dev;
            Console.WriteLine("****** CONVERSÃO IMPLICITA ******");
            Console.WriteLine($"Conversão implicita: int para long: {varLong}");
            Console.WriteLine($"Conversão implicita: float para double:{varDouble}");
            Console.WriteLine($"Conversão implicita: char para int:{varInt1}");
            Console.WriteLine($"Conversão implicita: por interpolação: {meuTexto}");
            Console.WriteLine($"Conversão implicita: classe filha para classe pai: "
                + $"Nome: {devfunc.Nome}, "
                + $"dt adm: {devfunc.DataAdmissao:dd/MM/yyyy}, "
                + $"dt nasc: {devfunc.DataNascimento:dd/MM/yyyy}");
            Console.WriteLine();

            // ****** CONVERSÃO EXPLÍCITA

            long varLongExp = 999329321939123;
            int varIntExp = (int)varLongExp;

            varInt = (int)varLong;
            string longParaString = varLong.ToString();
            decimal varDecimal = Convert.ToDecimal("15,2");
            varDecimal += 10;
            decimal.TryParse("morango", out decimal varDecimalTry);
            decimal.TryParse("20", out decimal varDecimalTry1);


            Console.WriteLine("****** CONVERSÃO EXPLICITA ******");

            if (devfunc is Programador info)
                Console.WriteLine($"Conversão explicita func e progamador: {info.Nome}");
            if(funcionario is Programador infoFunc)
                Console.WriteLine($"Conversão explicita func e programador: {infoFunc.Nome}");

            Console.WriteLine($"Conversão explicita: long(max) para int {varIntExp}");
            Console.WriteLine($"Conversão explicita: long para int {varInt}");
            Console.WriteLine($"Conversão explicita: long para string {longParaString}");
            Console.WriteLine($"Conversão explicita: string para decimal {varDecimal}");
            Console.WriteLine($"Conversão explicita: string para decimal via TryParse {varDecimalTry}");
            Console.WriteLine($"Conversão explicita: string para decimal via TryParse {varDecimalTry1}");




        }
    }

    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime DataAdmissao { get; set; }
    }
            
    public class Programador : Funcionario
    {
        public List<string> Linguagens { get; set; }
        public bool ConheceMetodologiaAgil { get; set; }
        public int AnosDeCarreira { get; set; }
    }

    
}
