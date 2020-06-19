using System;

namespace Aula20SENAIfood
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente mateus = new Cliente("Mateus", "Rua Tamarindo Cruz");
            Restaurante burguerKing = new Restaurante("Burguer King", "Avenida Francisco Barão");
            Pedido pedido1 = new Pedido();

            pedido1.Cliente = mateus;
            pedido1.Restaurante = burguerKing;

            System.Console.WriteLine( pedido1.EntregarPedido() );

            

            



        }
    }
}
