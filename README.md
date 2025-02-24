# DescontoCompra
Crie um programa que leia o valor total de uma compra. Se o valor for superior a R$ 100,00, aplique um desconto de 10%. Caso contrário, aplique um desconto de 5%. Exiba o valor final da compra após aplicar o desconto.

using System;

namespace CalculadoraDescontoCompra
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o valor total da compra
            Console.WriteLine("Digite o valor total da compra:");
            decimal valorCompra = Convert.ToDecimal(Console.ReadLine());

  // Verifica se o valor da compra é superior a R$ 100,00
            if (valorCompra > 100)
            {
  // Aplica um desconto de 10%
                decimal desconto = valorCompra * 0.10m;
                decimal valorFinal = valorCompra - desconto;

  // Exibe o valor final da compra
                Console.WriteLine($"Valor final da compra com 10% de desconto: {valorFinal.ToString("C")}");
            }
            else
            {
                // Aplica um desconto de 5%
                decimal desconto = valorCompra * 0.05m;
                decimal valorFinal = valorCompra - desconto;

  // Exibe o valor final da compra
                Console.WriteLine($"Valor final da compra com 5% de desconto: {valorFinal.ToString("C")}");
            }
        }
    }
}
