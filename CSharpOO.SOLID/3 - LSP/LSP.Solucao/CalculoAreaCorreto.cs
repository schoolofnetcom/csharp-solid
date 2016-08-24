using System;

//LSP = Princípio Da Substituição de Liskov
namespace CSharpOO.SOLID.LSP.Solucao
{
    public class CalculoAreaCorreto
    {
        private static void ObterAreaParalelogramo(Paralelogramo par)
        {
            Console.Clear();
            Console.WriteLine("Calculo da área do Paralelogramo");
            Console.WriteLine();
            Console.WriteLine(par.Altura + " * " + par.Largura);
            Console.WriteLine();
            Console.WriteLine(par.Area);
            Console.ReadKey();
        }

        public static void Calcular()
        {
            //var quad = new Quadrado(10, 10);
            var ret = new Retangulo(20, 30);
            ObterAreaParalelogramo(ret);
        }
    }
}
