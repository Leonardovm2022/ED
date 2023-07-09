// Leonardo Vecchi Meirelles
// 12011ECP002

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaFinalEDEx1
{
    public class NohLista<T>
    {
        public T data { get; set; }
        public NohLista<T> prior { get; set; }
        public NohLista<T> next { get; set; }

        public NohLista()
        {
        }

        public NohLista(T objeto)
        {
            data = objeto;
        }
    }
}
