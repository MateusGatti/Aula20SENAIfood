using System;

namespace Aula20SENAIfood
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente mateus = new Cliente("Mateus", "Rua Tamarindo Cruz");
            Restaurante hamburgueria = new Restaurante("SENAIfood", "Avenida Francisco Barão");
            Pedido produto = new Pedido();

            produto.FormaPGTO = "Cartão";

            System.Console.WriteLine(  mateus.MostrarDados() );
            System.Console.WriteLine( hamburgueria.MostrarDados() );

            string[] Itens = new string[5]{"X Burguer", "X Bacon", "X Salada", "X Tudo", "X Churrasco"};

            if(produto.FormaPGTO == "Dinheiro"){
                produto.PedidoPago = true;
            }else if(produto.FormaPGTO == "Cartão"){
                produto.PedidoPago = true;
            }else{
                produto.PedidoPago = false;
            }

            if(produto.PedidoPago == true){
                System.Console.WriteLine($"{Itens[2]} irá ser entregue para você");
                System.Console.WriteLine( produto.EntregarPedido(Itens[2]) );
            }



        }
    }
}
