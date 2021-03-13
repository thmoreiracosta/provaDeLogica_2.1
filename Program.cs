using System;
using System.Globalization;

namespace provaDeLogica_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercício 2.1:
            // Com base na tabela de preços abaixo, faça um programa que leia o código de um item e a 
            // quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.

            // CODIGO      ESPECIFICAÇÃO        PREÇO
            //   1         Cachorro Quente      R$ 4.00
            //   2         X-Salada             R$ 4.50
            //   3         X-Bacon              R$ 5.00
            //   4         Torrada simples      R$ 2.00
            //   5         Refrigerante         R$ 1.50

            int i, qtd;
            double total;            
            double[] preco = new double[5] {4.00, 4.50, 5.00, 2.00, 1.50};
            total = 0;

            string[] vet = Console.ReadLine().Split(' ');
            i = int.Parse(vet[0]);
            qtd = int.Parse(vet[1]);

            if (i == 1) {
                total = (double) qtd * preco[i-1];
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            } else if (i == 2) {
                total = (double) qtd * preco[i-1];
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            } else if (i == 3) {
                total = (double) qtd * preco[i-1];
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            } else if (i == 4) {
                total = (double) qtd * preco[i-1];
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            } else if (i == 5) {
                total = (double) qtd * preco[i-1];
                Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
            } else {
                Console.WriteLine("Esse código não está no cardápio!");
            }     
        }
    }
}
