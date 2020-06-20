using System;
namespace SenaiFoodNovo
{
    public class Pedido
    {
        public string[] Itens;
        public Cliente Cliente;
        public Restaurante Restaurante;
        public string FormaPGTO;
        public bool PedidoPago;
        public DateTime DataEntrega;
        public string EntregarPedido(){
            DataEntrega = DateTime.Now;

            string retorno = "Pedido Entregue!\n";
            retorno += Cliente.MostrarDados();
            retorno += Restaurante.MostrarDados();
            retorno += DataEntrega;


            return retorno;
        }
    }
}