using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Instancia 

            Clalculos calculos = new Clalculos();
            int total = calculos.Somar(1, 6);
            int resto = calculos.Subtrair(1, 6);

            Produto prod = new Produto();
            prod.Nome = "Mouse";
            prod.Preco = 100;

            Console.WriteLine(prod.Nome);
            Console.WriteLine(prod.Preco);

            Console.WriteLine("Total: {0}, {1}", total, resto);

            Console.ReadLine();
        }
    }
}
