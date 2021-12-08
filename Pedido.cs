using System;
using System.Collections.Generic;

namespace atvSenac_C
{
    public class Pedido
    {       //Propriedade lista ItemPedido
            private List<ItemPedido>itens;

            //Construtor para instanciar uma nova lista na propriedade criada
            public Pedido(){
                itens = new List<ItemPedido>();
            }

            //Método para incluir item ao pedido
            public void adicionar(ItemPedido pedidos){
                itens.Add(pedidos);

            }
            
            //Método para retornar o total do valor do pedido
            public double totalizar(){
                double valorAtual= 0;
                    for(int i = 0; i < itens.Count; i++){
                    valorAtual = itens[i].valor_unitario * itens[i].quantidade + valorAtual;
                    }
                return valorAtual;
            }




    }
}