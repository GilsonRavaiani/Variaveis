using System;

namespace Variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 10;// Variável de 8 bits pode armazenar entre 0 e 255
            int num = 0;
            char letra = 'c';//Usado apóstrofo
            float valor = 5.3f;
            string nome = "Guiando";//Usado aspas 

            //var aux=10;
            //var aux="Guiando Pessoas";
            var aux = nome;
            var fixo = valor;
            var number = num;
            var bite = n1;

            //Console.WriteLine(aux);
            //Console.WriteLine("Valor da variável: " + aux + "...");    //concatena string com variável  
            //Console.WriteLine(fixo);
            //Console.WriteLine(number);
            //Console.WriteLine(bite);
            Console.WriteLine("Concatenando mais variáveis: " + aux + fixo + number + bite);
            Console.ReadLine();
            Console.WriteLine("Nome: {0}, Fixo: {1}, Number: {2}, Bite: {3}", aux, fixo, number, bite);
            Console.ReadLine();

            //Console.WriteLine("Hello World!");
        }
    }
}
