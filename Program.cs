using System;

namespace exercicio_logica_programacao4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Equação de 2 grau(bhaskara)

            //Utilizando funções, faça um programa que calcule as raízes da equação do 2 grau conforme a fórmula de Bhaskara.
            //Os valores de A, B e C deverão ser entradas realizadas pelo usuário.

            //Lembre - se: o Google vai te ajudar a lembrar sobre como realizar o cálculo da equação. 
            //Todo desenvolvedor precisa pesquisar, e muito! :)

            //Lembrando:

            //ax(2) + bx + c = 0

            //delta = (Δ = b2 - 4.a.c)
            //x1 = ((-b + √Δ)/ 2a)
            //x2 = ((-b - √Δ)/ 2a)

            Console.WriteLine("Informe valor A:");
            int valorA = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Informe valor B:");
            int valorB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe valor C:");
            int valorC = Convert.ToInt32(Console.ReadLine());

            double delta = valorB ^ 2 - (4 * valorA * valorC);

            Console.WriteLine(delta);

            double raiz = Math.Sqrt(delta);
            var x1 = ((-(valorB)) + raiz) / (2 * valorA);
            var x2 = ((-(valorB)) - raiz) / (2 * valorA);

            Console.WriteLine("Valor de X': {0}", x1);
            Console.WriteLine("Valor de X'': {0}", x2);


        }
    }
}
