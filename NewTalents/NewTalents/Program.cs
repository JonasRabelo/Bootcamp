using System;

namespace NewTalents
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calculadora = new Calculadora();

            calculadora.Somar(1, 2);
            calculadora.Porcentagem(20, 54);
            calculadora.Raiz(144);

            foreach (string calculo in calculadora._historico)
            {
                Console.WriteLine(calculo);
            }
        }
    }
}