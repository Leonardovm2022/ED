using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoFinalED
{
    public class PriorityQueue<T>
    {
        private readonly SortedList<double, T> _list = new SortedList<double, T>();

        public void Enqueue(T item, double priority, int id)
        {
            _list.Add(priority + (1.0 / (id + 1)), item);
        }

        public T Dequeue()
        {
            var first = _list.First();
            _list.RemoveAt(0);
            return first.Value;
        }

        public T Peek()
        {
            return _list.Values[0];
        }

        public int Count => _list.Count;
    }

}
