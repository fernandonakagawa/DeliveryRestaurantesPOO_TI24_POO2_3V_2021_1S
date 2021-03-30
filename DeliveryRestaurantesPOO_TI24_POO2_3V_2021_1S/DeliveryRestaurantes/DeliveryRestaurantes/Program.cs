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


            regLondrina.mostrarRestaurantes();
            r2.mostrarCardapio();
        }
    }
}
