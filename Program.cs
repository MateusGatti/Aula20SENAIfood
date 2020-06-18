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

            

            System.Console.WriteLine(  mateus.MostrarDados() );
            System.Console.WriteLine( hamburgueria.MostrarDados() );

            string[] Itens = new string[5]{"XBurguer", "XBacon", "XSalada", "XTudo", "XChurrasco"};

            System.Console.WriteLine("A forma de pagamento será Dinheiro ou Cartão?");
            produto.FormaPGTO = Console.ReadLine();
            

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

            // Não consegui fazer a escolha da comida ;-;



        }
    }
}
