using System;
using ListaExercicio.Models;

namespace ListaExercicio.Views
{
    public class OO
    {
        public static void Renderizar()
        {
            Produto produto = new Produto();
            produto.Nome = "Bolacha";
            produto.Preco = 3.5;
            double valorFinal = produto.Preco * 2;
            Console.WriteLine($"Nome do produto: { produto.Nome }");
        }
    }
}