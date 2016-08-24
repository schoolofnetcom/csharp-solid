//LSP = Princípio Da Substituição de Liskov
namespace CSharpOO.SOLID.LSP.Problema
{
    public class Retangulo
    {
        public virtual double Altura { get; set; }
        public virtual double Largura { get; set; }
        public double Area { get { return Altura * Largura; } }
    }
}