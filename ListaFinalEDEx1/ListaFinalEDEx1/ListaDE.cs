// Leonardo Vecchi Meirelles
// 12011ECP002

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFinalEDEx1
{
    public class ListaDE<T>
    {
        public NohLista<T> INICIO { get; set; }
        public NohLista<T> FIM { get; set; }

        public ListaDE()
        {
        }

        public bool estaVazia()
        {
            return INICIO == null;
        }

        public void insereNoInicio(T objeto)
        {
            NohLista<T> novo = new NohLista<T>(objeto);
            if (estaVazia())
            {
                INICIO = novo;
                FIM = novo;
            }
            else
            {
                novo.next = INICIO;
                INICIO.prior = novo;
                INICIO = novo;
            }
        }

        public void insereNoFim(T objeto)
        {
            NohLista<T> novo = new NohLista<T>(objeto);
            if (estaVazia())
            {
                INICIO = novo;
                FIM = novo;
            }
            else
            {
                novo.prior = FIM;
                FIM.next = novo;
                FIM = novo;
            }
        }

        public T removeDoInicio()
        {
            if (estaVazia())
            {
                return default(T);
            }
            else
            {
                T objeto = INICIO.data;
                INICIO = INICIO.next;
                if (INICIO != null)
                {
                    INICIO.prior = null;
                }
                else
                {
                    FIM = null;
                }
                return objeto;
            }
        }

        public T removeDoFim()
        {
            if (estaVazia())
            {
                return default(T);
            }
            else
            {
                T objeto = FIM.data;
                FIM = FIM.prior;
                if (FIM != null)
                {
                    FIM.next = null;
                }
                else
                {
                    INICIO = null;
                }
                return objeto;
            }
        }

        public void imprime()
        {
            NohLista<T> atual = INICIO;
            while (atual != null)
            {
                Console.WriteLine(atual.data);
                atual = atual.next;
            }
        }
    }
}
