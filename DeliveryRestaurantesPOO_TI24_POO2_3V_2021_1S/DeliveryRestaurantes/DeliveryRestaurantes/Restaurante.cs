using System;
using System.Collections.Generic;
using System.Text;

namespace DeliveryRestaurantes
{
    class Restaurante
    {
        public string nome, endereco, cnpj;
        public Cardapio cardapio;
        public List<Pedido> pedidos;
        
        public Restaurante(string nome, string endereco, string cnpj)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.cnpj = cnpj;
            this.cardapio = new Cardapio();
        }
        public bool aceitaPedido(List<Produto> p)
        {
            if (p.Count > 0 && p.Count <= 5)
            {
                this.pedidos.Add(new Pedido(p));
                return true;
            }
            return false;
        }
        public void mostrarPedidos()
        {
            Console.WriteLine($"=====Pedidos do restaurante {nome}=======");
            foreach (Pedido p in this.pedidos)
            {
                Console.WriteLine($"{p.entregue} {p.endereco}  {p.nomeCliente}");
            }
            Console.WriteLine();
        }
        public void mostrarCardapio()
        {
            Console.WriteLine($"=====Cardápio do restaurante {nome}=======");
            foreach(Produto p in cardapio.produtos)
            {
                Console.WriteLine($"{p.nome} {p.descricao} {p.valor}");
                //Saída: PF de Feijoada 500g de pura feijoada 15

                //Console.WriteLine("{p.nome} {p.descricao} {p.valor}");
                //{p.nome} {p.descricao} {p.valor}

                // sem $: Console.WriteLine("" + p.nome + " " + p.descricao + " " + p.valor);
            }
            Console.WriteLine();
        }
        public void adicionarProduto(Produto p)
        {
            this.cardapio.adicionarProduto(p);
        }
    }
}
