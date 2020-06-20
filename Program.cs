using System;

namespace SenaiFoodNovo
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gustavo = new Cliente("Gustavo");
            gustavo.Endereco = "Avenida Itaquera";
            Restaurante bk = new Restaurante("Burger King", "Av Aricanduva");
            Pedido pedido1 = new Pedido();
            pedido1.Cliente = gustavo;
            pedido1.Restaurante = bk;
            System.Console.WriteLine(pedido1.EntregarPedido());
        }
    }
}
