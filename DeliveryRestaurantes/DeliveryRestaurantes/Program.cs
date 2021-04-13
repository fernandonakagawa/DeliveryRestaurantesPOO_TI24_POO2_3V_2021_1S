using System;
using System.Collections.Generic;

namespace DeliveryRestaurantes
{
    class Program
    {
        static void Main(string[] args)
        {
            RestaurantesRegiao regLondrina = new RestaurantesRegiao("Londrina");

            Restaurante r1 = new Restaurante("Comida Mineirinha", "Rua Belém", "123456");
            Produto p1 = new Produto("PF de feijoada", "500g de pura feijoada", 15f);
            Produto p2 = new Produto("Marmita Média", "Marmita de 400g variada", 12.50f);
            r1.cardapio.adicionarProduto(p1);
            r1.cardapio.adicionarProduto(p2);
            regLondrina.adicionarRestaurante(r1);

            Restaurante r2 = new Restaurante("Comida Japonesa", "Rua Amapá", "23456789");
            Produto p3 = new Produto("Temaki", "Temaki de salmão", 12f);
            Produto p4 = new Produto("Sushi", "12 peças de sushi variados", 15.50f);
            r2.cardapio.adicionarProduto(p3);
            r2.cardapio.adicionarProduto(p4);
            regLondrina.adicionarRestaurante(r2);

            regLondrina.removerRestaurante(r1);
            regLondrina.mostrarRestaurantes();
            r2.mostrarCardapio();

            RestaurantesRegiao regMaringa = new RestaurantesRegiao("Maringá");
            Restaurante r3 = new Restaurante("Resturante Canção", "Av Colombo", "444444");
            Produto p5 = new Produto("Baião de 2", "Arroz com feijão e temperos", 13.50f);
            Produto p6 = new Produto("Ovo cozido", "Ovos de codorna", 6.50f);
            r3.cardapio.adicionarProduto(p5);
            r3.cardapio.adicionarProduto(p6);
            regMaringa.adicionarRestaurante(r3);

            r3.removerProduto(p6);

            regMaringa.mostrarRestaurantes();
            r3.mostrarCardapio();

            Pedido pedido1 = new Pedido("Diego");
            pedido1.adicionarProduto(p1);
            pedido1.adicionarProduto(p2);
            pedido1.entregar();
            pedido1.mostrarPedido();
            r3.adicionarPedido(pedido1);
            r3.criarPedido("Joao", new Produto[]{p5});
            r2.criarPedido("Dhayvison", new Produto[] { p3, p4 });
            r2.criarPedido("Matheus", new Produto[] { p3 });
            r2.criarPedido("Raul", new Produto[] { p4 });
            r3.mostrarPedidos(Restaurante.TipoPedido.NaoEntregue);
            r3.mostrarPedidos(Restaurante.TipoPedido.Entregue);
            r3.mostrarPedidos(Restaurante.TipoPedido.Todos);
            r2.mostrarPedidos(Restaurante.TipoPedido.NaoEntregue);
            r2.mostrarPedidos(Restaurante.TipoPedido.Entregue);
            r2.mostrarPedidos(Restaurante.TipoPedido.Todos);
        }
    }
}
