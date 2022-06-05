using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block2_1
{
    public static class ExtensionMethods
    {
        public static bool All<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate");
            }

            foreach (TSource item in source)
            {
                if (!predicate(item))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool Any<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            using (IEnumerator<TSource> iterator = source.GetEnumerator())
            {
                return iterator.MoveNext();
            }
        }
        
        public static bool Any<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (predicate == null)
            {
                throw new ArgumentNullException("predicate");
            }

            foreach (TSource item in source)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null) throw new ArgumentNullException("Некорректное значение параметра");
            if (second == null) throw new ArgumentNullException("Некорректное значение параметра");
            return ConcatIterator<TSource>(first, second);
        }

        static IEnumerable<TSource> ConcatIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            foreach (TSource element in first)
            {
                yield return element;
            }
            foreach (TSource element in second)
            {
                yield return element;
            }

        }

        public static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value)
        {
            ICollection<TSource> collection = source as ICollection<TSource>;
            if (collection != null) return collection.Contains(value);
            return Contains(source, value, null);
        }

        public static TSource Append<TSource>(this LinkedList<TSource> source, TSource value)
        {
            source.AddLast(value);
            return value;
        }

        static bool Contains<TSource>(this IEnumerable<TSource> source, TSource value, IEqualityComparer<TSource> comparer)
        {
            if (comparer == null) comparer = EqualityComparer<TSource>.Default; //IEqualityComparer<T>: определяет методы, с помощью которых два однотипных объекта сравниваются на предмет равенства
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            foreach (TSource element in source)
            {
                if (comparer.Equals(element, value)) return true;
            }
            return false;
        }

        public static int Count<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            ICollection<TSource> collectionoft = source as ICollection<TSource>;
            if (collectionoft != null) return collectionoft.Count;
            ICollection<TSource> collection = source as ICollection<TSource>;
            if (collection != null) return collection.Count;
            int count = 0;
            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                checked
                {
                    while (e.MoveNext()) count++;
                }
            }
            return count;
        }

        public static int Count<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            if (predicate == null) throw new ArgumentNullException("Некорректное значение параметра");
            int count = 0;
            foreach (TSource element in source)
            {
                checked
                {
                    if (predicate(element)) count++;
                }
            }
            return count;
        }

        public static IEnumerable<TSource> Distinct<TSource>(this IEnumerable<TSource> source, IEqualityComparer<TSource> comparer = null)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            HashSet<TSource> set = new HashSet<TSource>(comparer);
            foreach (TSource element in source)
            {
                if (set.Add(element)) yield return element;
            }
        }

        public static TSource ElementAt<TSource>(this IEnumerable<TSource> source, int index)
        {
            if (source == null) throw new ArgumentNullException("source");
            IList<TSource> list = source as IList<TSource>;
            if (list != null) return list[index];
            if (index < 0) throw new ArgumentNullException("index");
            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                while (true)
                {
                    if (!e.MoveNext()) throw new ArgumentNullException("index");
                    if (index == 0) return e.Current;
                    index--;
                }
            }
        }

        public static TSource ElementAtOrDefault<TSource>(this IEnumerable<TSource> source, int index)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            if (index >= 0)
            {
                IList<TSource> list = source as IList<TSource>;
                if (list != null)
                {
                    if (index < list.Count) return list[index];
                }
                else
                {
                    using (IEnumerator<TSource> e = source.GetEnumerator())
                    {
                        while (true)
                        {
                            if (!e.MoveNext()) break;
                            if (index == 0) return e.Current;
                            index--;
                        }
                    }
                }
            }
            return default(TSource);
        }
         
        public static IEnumerable<TSource> Except<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null) throw new ArgumentNullException("Некорректное значение параметра");
            if (second == null) throw new ArgumentNullException("Некорректное значение параметра");
            return ExceptIterator<TSource>(first, second, null);
        }

        static IEnumerable<TSource> ExceptIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            HashSet<TSource> set = new HashSet<TSource>(comparer);
            foreach (TSource element in second)
            {
                set.Add(element);
            }
            foreach (TSource element in first)
            {
                if (set.Add(element)) yield return element;
            }
        }

        public static TSource First<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count > 0) return list[0];
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (e.MoveNext()) return e.Current;
                }
            }
            throw new Exception("Нет элемента");
        }

        public static TSource FirstOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                if (list.Count > 0) return list[0];
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (e.MoveNext()) return e.Current;
                }
            }
            return default(TSource);
        }

        public static IEnumerable<TSource> Intersect<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null) throw new ArgumentNullException("Некорректное значение параметра");
            if (second == null) throw new ArgumentNullException("Некорректное значение параметра");
            return IntersectIterator<TSource>(first, second, null);
        }

        static IEnumerable<TSource> IntersectIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            HashSet<TSource> set = new HashSet<TSource>(comparer);
            foreach (TSource element in second)
            {
                set.Add(element);
            }
            foreach (TSource element in first)
            {
                if (set.Remove(element)) yield return element;
            }

        }

        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(this IEnumerable<TSource> source,Func<TSource, TKey> keySelector)
        {
            return OrderBy(source, keySelector, Comparer<TKey>.Default);
        }

        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (keySelector == null)
            {
                throw new ArgumentNullException("keySelector");
            }
            return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer ?? Comparer<TKey>.Default);
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            return OrderByDescending(source, keySelector, Comparer<TKey>.Default);
        }

        public static IOrderedEnumerable<TSource> OrderByDescending<TSource, TKey>( this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IComparer<TKey> comparer)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (keySelector == null)
            {
                throw new ArgumentNullException("keySelector");
            }
            comparer = new ReverseComparer<TKey>(comparer ?? Comparer<TKey>.Default);
            return new OrderedEnumerable<TSource, TKey>(source, keySelector, comparer);
        }

        public static TSource Last<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                int count = list.Count;
                if (count > 0) return list[count - 1];
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (e.MoveNext())
                    {
                        TSource result;
                        do
                        {
                            result = e.Current;
                        } while (e.MoveNext());
                        return result;
                    }
                }
            }
            throw new Exception("Нет элемента");
        }

        public static TSource LastOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                int count = list.Count;
                if (count > 0) return list[count - 1];
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (e.MoveNext())
                    {
                        TSource result;
                        do
                        {
                            result = e.Current;
                        } while (e.MoveNext());
                        return result;
                    }
                }
            }
            return default(TSource);
        }

        public static long LongCount<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            long count = 0;
            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                checked
                {
                    while (e.MoveNext()) count++;
                }
            }
            return count;
        }

        public static TSource Max<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            Comparer<TSource> comparer = Comparer<TSource>.Default;
            TSource value = default(TSource);
            if (value == null)
            {
                foreach (TSource x in source)
                {
                    if (x != null && (value == null || comparer.Compare(x, value) > 0))
                        value = x;
                }
                return value;
            }
            else
            {
                bool hasValue = false;
                foreach (TSource x in source)
                {
                    if (hasValue)
                    {
                        if (comparer.Compare(x, value) > 0)
                            value = x;
                    }
                    else
                    {
                        value = x;
                        hasValue = true;
                    }
                }
                if (hasValue) return value;
                throw new Exception("нет элементов");
            }
        }

        public static TSource Min<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            Comparer<TSource> comparer = Comparer<TSource>.Default;
            TSource value = default(TSource);
            if (value == null)
            {
                foreach (TSource x in source)
                {
                    if (x != null && (value == null || comparer.Compare(x, value) < 0))
                        value = x;
                }
                return value;
            }
            else
            {
                bool hasValue = false;
                foreach (TSource x in source)
                {
                    if (hasValue)
                    {
                        if (comparer.Compare(x, value) < 0)
                            value = x;
                    }
                    else
                    {
                        value = x;
                        hasValue = true;
                    }
                }
                if (hasValue) return value;
                throw new Exception("нет элементов");
            }
        }

        public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            return ReverseIterator<TSource>(source);
        }

        static IEnumerable<TSource> ReverseIterator<TSource>(IEnumerable<TSource> source)
        {
            Buffer<TSource> buffer = new Buffer<TSource>(source);
            for (int i = buffer.count - 1; i >= 0; i--) yield return buffer.items[i];
        }

        public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer = null)
        {
            if (comparer == null) comparer = EqualityComparer<TSource>.Default;
            if (first == null) throw new ArgumentNullException("Некорректное значение параметра");
            if (second == null) throw new ArgumentNullException("Некорректное значение параметра");
            using (IEnumerator<TSource> e1 = first.GetEnumerator())
            using (IEnumerator<TSource> e2 = second.GetEnumerator())
            {
                while (e1.MoveNext())
                {
                    if (!(e2.MoveNext() && comparer.Equals(e1.Current, e2.Current))) return false;
                }
                if (e2.MoveNext()) return false;
            }
            return true;
        }

       public static TSource Single<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                switch (list.Count)
                {
                    case 0: throw new Exception("нет элементов");
                    case 1: return list[0];
                }
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (!e.MoveNext()) throw new Exception("нет элементов");
                    TSource result = e.Current;
                    if (!e.MoveNext()) return result;
                }
            }
            throw new Exception("Больше чем один элемент");
        }

        public static TSource SingleOrDefault<TSource>(this IEnumerable<TSource> source)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            IList<TSource> list = source as IList<TSource>;
            if (list != null)
            {
                switch (list.Count)
                {
                    case 0: return default(TSource);
                    case 1: return list[0];
                }
            }
            else
            {
                using (IEnumerator<TSource> e = source.GetEnumerator())
                {
                    if (!e.MoveNext()) return default(TSource);
                    TSource result = e.Current;
                    if (!e.MoveNext()) return result;
                }
            }
            return default(TSource);
        }

        public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> source, int count)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            if (count > 0)
            {
                foreach (TSource element in source)
                {
                    yield return element;
                    if (--count == 0) break;
                }
            }
        }

        public static IEnumerable<TSource> TakeLast<TSource>(this IEnumerable<TSource> source, int count)
        {
            if (source == null) throw new ArgumentNullException("Некорректное значение параметра");
            return TakeLastIterator<TSource>(source, count);
        }

        static IEnumerable<TSource> TakeLastIterator<TSource>(IEnumerable<TSource> source, int count)
        {
            using (IEnumerator<TSource> e = source.GetEnumerator())
            {
                while (count > 0 && e.MoveNext()) count--;
                if (count <= 0)
                {
                    while (e.MoveNext()) yield return e.Current;
                }
            }
        }

        public static IEnumerable<TSource> Union<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null) throw new ArgumentNullException("Некорректное значение параметра");
            if (second == null) throw new ArgumentNullException("Некорректное значение параметра");
            return UnionIterator<TSource>(first, second, null);
        }

        public static TSource Prepend<TSource>(this LinkedList<TSource> source, TSource value)
        {
            source.AddFisrt(value);
            return value;
        }
        
        static IEnumerable<TSource> UnionIterator<TSource>(IEnumerable<TSource> first, IEnumerable<TSource> second, IEqualityComparer<TSource> comparer)
        {
            HashSet<TSource> set = new HashSet<TSource>(comparer);
            foreach (TSource element in first)
                if (set.Add(element)) yield return element;
            foreach (TSource element in second)
                if (set.Add(element)) yield return element;
        }

    }

    struct Buffer<TElement>
    {
        internal TElement[] items;
        internal int count;

        internal Buffer(IEnumerable<TElement> source)
        {
            TElement[] items = null;
            int count = 0;
            ICollection<TElement> collection = source as ICollection<TElement>;
            if (collection != null)
            {
                count = collection.Count;
                if (count > 0)
                {
                    items = new TElement[count];
                    collection.CopyTo(items, 0);
                }
            }
            else
            {
                foreach (TElement item in source)
                {
                    if (items == null)
                    {
                        items = new TElement[4];
                    }
                    else if (items.Length == count)
                    {
                        TElement[] newItems = new TElement[checked(count * 2)];
                        Array.Copy(items, 0, newItems, 0, count);
                        items = newItems;
                    }
                    items[count] = item;
                    count++;
                }
            }
            this.items = items;
            this.count = count;
        }

        internal TElement[] ToArray()
        {
            if (count == 0) return new TElement[0];
            if (items.Length == count) return items;
            TElement[] result = new TElement[count];
            Array.Copy(items, 0, result, 0, count);
            return result;
        }
    }

    
}
