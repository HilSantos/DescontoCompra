using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DescontoCompra
{
    public class Program
    {
        static void Main(string[] args)
        {
            decimal Porcentagem, desconto, valor;

            Console.WriteLine("Informe o preço do produto: ");
            valor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a Porcentagem de desconto: ");
            Porcentagem = Convert.ToInt32(Console.ReadLine());

            desconto = valor * (Porcentagem / 100);

            Console.WriteLine("Subtraia o valor do desconto do preço: ");
            desconto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Exibir o valor do desconto e o preço final: " + valor);
            valor = Convert.ToDecimal(Console.ReadLine());


            if (valor > 100)
            {
                Console.WriteLine("Aplique desconto de 10%");
            }
            else
            {
                Console.WriteLine("Aplique desconto de 5%");
            }
            Console.ReadKey();
        }
    }
}
