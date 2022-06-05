using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_1
{
    public class LinkedList<T> : IEnumerable<T>
    {
        internal Node<T> _first;
        internal Node<T> _last;
        internal int _count;
        
        public Node<T> First { get { return _first; } }
        public Node<T> Last { get { return _last; } }
        public int Count { get { return _count; } }

        public LinkedList()
        {
            //  Инициализирует новый экземпляр пустого класса DoublyLinkedList<T>
        }

        public LinkedList(IEnumerable<T> collection)
        {
            if (collection == null) throw new ArgumentNullException("Некорректное значение параметра");
            foreach (var item in collection)
            {
                Node<T> node = new Node<T>(item);

                if (_first == null)
                    _first = node;
                else
                {
                    _last.Next = node;
                    node.Previous = _last;
                }
                _last = node;
                _count++;
            }
        }

        public void AddLast(T newdata)
        {
            Node<T> node = new Node<T>(newdata);

            if (_first == null)
                _first = node;
            else
            {
                _last.Next = node;
                node.Previous = _last;
            }
            _last = node;
            _count++;
            //return node;
        }

        public void AddLast(Node<T> newnode)
        {
            if (_first == null)
                _first = newnode;
            else
            {
                _last.Next = newnode;
                newnode.Previous = _last;
            }
            _last = newnode;
            _count++;
        }

        public void AddFisrt(T newdata)
        {
            Node<T> node = new Node<T>(newdata);
            Node<T> temp = _first;

            node.Next = temp;
            _first = node;
            if (_count == 0)
                _last = _first;
            else
                temp.Previous = node;
            _count++;

        }

        public void AddFirst(Node<T> newnode)
        {
            Node<T> temp = _first;

            newnode.Next = temp;
            _first = newnode;
            if (_count == 0)
                _last = _first;
            else
                temp.Previous = newnode;
            _count++;
        }

        public void AddAfter(Node<T> node, T newdata)
        {
            if (_first == null)
            {
                return;
            }
            Node<T> data = new Node<T>(newdata);
            
            if (data != null)
            {                
                data.Next = node.Next;
                data.Previous = node;
                node.Next.Previous = data;
                node.Next = data;
                _count++;
            }
        }

        public void AddAfter(Node<T> node, Node<T> newnode)
        {
            if (_first == null)
            {
                return;
            }
            newnode.Next = node.Next;
            newnode.Previous = node;
            node.Next.Previous = newnode;
            node.Next = newnode;

            _count++;
        }

        public void AddBefore(Node<T> node, T newdata)
        {
            if (_first == null)
            {
                return;
            }
            Node<T> data = new Node<T>(newdata);
            if (data != null)
            {
                data.Next = node;
                data.Previous = node.Previous;
                node.Previous.Next = data;
                node.Previous = data;
                _count++;
            }
        }

        public void AddBefore(Node<T> node, Node<T> newnode)
        {
            if (_first == null)
            {
                return;
            }
            newnode.Next = node;
            newnode.Previous = node.Previous;
            node.Previous.Next = newnode;
            node.Previous = newnode;
            _count++;
        }

        public Node<T> Find(T data)
        {
            Node<T> current = _first;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return current;
                current = current.Next;
            }
            return null;
        }

        public Node<T> FindLast(T data)
        {
            Node<T> current = _last;
            while (current != null)
            {
                if (data != null)
                {
                    if (current.Data.Equals(data))
                        return current;
                    current = current.Previous;
                }
            }
            return null;
        }

        public void RemoveFirst()
        {
            _first = _first.Next;
            _first.Previous = null;
            _count--;
        }

        public void RemoveLast()
        {
            _last = _last.Previous;
            _last.Next = null;
            _count--;
        }

        public bool Remove(T data)
        {
            Node<T> current = _first;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    _last = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    _first = current.Next;
                }
                _count--;
                return true;
            }
            return false;
        }

        public bool Remove(Node<T> data)
        {
            Node<T> current = _first;

            while (current != null)
            {
                if (current.Data.Equals(data.Data))
                {
                    break;
                }
                current = current.Next;
            }
            if (current != null)
            {
                if (current.Next != null)
                {
                    current.Next.Previous = current.Previous;
                }
                else
                {
                    _last = current.Previous;
                }

                if (current.Previous != null)
                {
                    current.Previous.Next = current.Next;
                }
                else
                {
                    _first = current.Next;
                }
                _count--;
                return true;
            }
            return false;
        }
        
        public void Clear()
        {
            _first = null;
            _last = null;
            _count = 0;
        }

        public void CopyTo(T[] array, int index)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Массив пуст");
            }

            if (index < 0 || index > array.Length)
            {
                throw new ArgumentOutOfRangeException("аргумента находится вне диапазона допустимых значений");
            }

            if (array.Length - index < Count)
            {
                throw new ArgumentException("Индекс находился вне границ массива.");
            }
            Node<T> curent = _first;
            if (curent != null)
            {
                do
                {
                    array[index++] = curent.Data;
                    curent = curent.Next;
                } while (curent != null);
            }
        }

        public bool Constains(T data)
        {
            Node<T> current = _first;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void Print()
        {
            Node<T> current = _first;
            while (current != null)
            {
                Console.Write(current.Data + " > ");
                current = current.Next;
            }
            Console.WriteLine();
            Console.WriteLine();
        }

       
        public void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Узел '{0}' отсутствует в списке.\n",
                    node.Value);
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Node<T> current = _first;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public IEnumerable<T> BackEnumerator()
        {
            Node<T> current = _last;
            while (current != null)
            {
                yield return current.Data;
                current = current.Previous;
            }
        }

        public override bool Equals(object obj)
        {

            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                LinkedList<T> data = (LinkedList<T>)obj;
                Node<T> current = _first;
                Node<T> currentObj = data._first;
                if (data._count == this._count)
                {
                    if (this._count > 0)
                    {
                        for (int i = 0; i < _count; i++)
                        {
                            if (!Equals(current.Data, currentObj.Data) ||
                                current.Previous != currentObj.Previous ||
                                current.Next != currentObj.Next)
                            {
                                return false;
                            }
                            current = current.Next;
                            currentObj = currentObj.Next;
                        }

                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
