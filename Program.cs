using System;
using System.Collections.Generic;

namespace atvSenac_C
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar = 'S';
            Pedido realizarPedido = new Pedido();

            /* 
               Faça:
                 Cria novo objeto;
                 Pergunta as informações dos itens;
                 O usuário informa e o programa armazena;
                 Pergunta se o usuário deseja acrescenatar mais itens no pedido.
               Enquanto:
                 O usuário desejar acrescentar itens ao pedido.
            */ 
            do{ 
                ItemPedido cliente = new ItemPedido();

                Console.WriteLine("Informe qual é o seu pedido:");
                cliente.descricao = Console.ReadLine();
                Console.WriteLine("Qual o valor desse pedido?");
                cliente.valor_unitario = double.Parse(Console.ReadLine());
                Console.WriteLine("Qual a quantidade desse pedido você vai querer?");
                cliente.quantidade = int.Parse(Console.ReadLine());

                realizarPedido.adicionar(cliente);

                Console.WriteLine("Deseja pedir mais alguma coisa? Digite (S) para sim ou (N) para não");
                continuar = char.Parse(Console.ReadLine());

            }while(continuar=='S' || continuar=='s');

            Console.WriteLine("O total do seu pedido foi: R$"+ realizarPedido.totalizar());

            Console.WriteLine("Volte sempre!");

        }
    }
}
