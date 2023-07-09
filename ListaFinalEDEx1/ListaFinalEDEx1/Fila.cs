// Leonardo Vecchi Meirelles
// 12011ECP002

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFinalEDEx1
{
    public class Fila<T>
    {
        private ListaDE<T> lista;

        public Fila()
        {
            lista = new ListaDE<T>();
        }

        public void enqueue(T objeto)
        {
            lista.insereNoFim(objeto);
        }

        public T dequeue()
        {
            return lista.removeDoInicio();
        }

        public bool estaVazia()
        {
            return lista.estaVazia();
        }

        public void imprime()
        {
            NohLista<T> atual = lista.INICIO;
            while (atual != null)
            {
                Console.WriteLine(atual.data);
                atual = atual.next;
            }
        }
    }
}
