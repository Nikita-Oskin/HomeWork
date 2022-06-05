
using System;
using System.Collections;
using System.Collections.Generic;

namespace Block2_1
{
    public static partial class Enumerable
    {
        internal static TSource[] ToBuffer<TSource>(this IEnumerable<TSource> source, out int count)
        {
            // Optimize for ICollection<T>
            ICollection<TSource> collection = source as ICollection<TSource>;
            if (collection != null)
            {
                count = collection.Count;
                TSource[] tmp = new TSource[count];
                collection.CopyTo(tmp, 0);
                return tmp;
            }

            // We'll have to loop through, creating and copying arrays as we go
            TSource[] ret = new TSource[16];
            int tmpCount = 0;
            foreach (TSource item in source)
            {
                // Need to expand...
                if (tmpCount == ret.Length)
                {
                    Array.Resize(ref ret, ret.Length * 2);
                }
                ret[tmpCount++] = item;
            }
            count = tmpCount;
            return ret;
        }
    }
    internal class ReverseComparer<T> : IComparer<T>
    {
        private readonly IComparer<T> forwardComparer;

        internal ReverseComparer(IComparer<T> forwardComparer)
        {
            this.forwardComparer = forwardComparer;
        }

        public int Compare(T x, T y)
        {
            return forwardComparer.Compare(y, x);
        }
    }
    internal struct CompositeKey<TPrimary, TSecondary>
    {
        private readonly TPrimary primary;
        private readonly TSecondary secondary;

        internal TPrimary Primary { get { return primary; } }
        internal TSecondary Secondary { get { return secondary; } }

        internal CompositeKey(TPrimary primary, TSecondary secondary)
        {
            this.primary = primary;
            this.secondary = secondary;
        }

        internal sealed class Comparer : IComparer<CompositeKey<TPrimary, TSecondary>>
        {
            private readonly IComparer<TPrimary> primaryComparer;
            private readonly IComparer<TSecondary> secondaryComparer;

            internal Comparer(IComparer<TPrimary> primaryComparer, IComparer<TSecondary> secondaryComparer)
            {
                this.primaryComparer = primaryComparer;
                this.secondaryComparer = secondaryComparer;
            }

            public int Compare(CompositeKey<TPrimary, TSecondary> x, CompositeKey<TPrimary, TSecondary> y)
            {
                int primaryResult = primaryComparer.Compare(x.Primary, y.Primary);
                if (primaryResult != 0)
                {
                    return primaryResult;
                }
                return secondaryComparer.Compare(x.Secondary, y.Secondary);
            }
        }
    }
    public interface IOrderedEnumerable<TElement> : IEnumerable<TElement>
    {
        IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(
            Func<TElement, TKey> keySelector,
            IComparer<TKey> comparer,
            bool descending);
    }
    internal class OrderedEnumerable<TElement, TCompositeKey> : IOrderedEnumerable<TElement>
    {
        private readonly IEnumerable<TElement> source;
        private readonly Func<TElement, TCompositeKey> compositeSelector;
        private readonly IComparer<TCompositeKey> compositeComparer;

        internal OrderedEnumerable(IEnumerable<TElement> source,
            Func<TElement, TCompositeKey> compositeSelector,
            IComparer<TCompositeKey> compositeComparer)
        {
            this.source = source;
            this.compositeSelector = compositeSelector;
            this.compositeComparer = compositeComparer;
        }

        public IOrderedEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
        {
            if (keySelector == null)
            {
                throw new ArgumentNullException("keySelector");
            }
            comparer = comparer ?? Comparer<TKey>.Default;
            if (descending)
            {
                comparer = new ReverseComparer<TKey>(comparer);
            }

            // Copy to a local variable so we don't need to capture "this"
            Func<TElement, TCompositeKey> primarySelector = compositeSelector;
            Func<TElement, CompositeKey<TCompositeKey, TKey>> newKeySelector =
                element => new CompositeKey<TCompositeKey, TKey>(primarySelector(element), keySelector(element));

            IComparer<CompositeKey<TCompositeKey, TKey>> newKeyComparer =
                new CompositeKey<TCompositeKey, TKey>.Comparer(compositeComparer, comparer);

            return new OrderedEnumerable<TElement, CompositeKey<TCompositeKey, TKey>>
                (source, newKeySelector, newKeyComparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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
        public IEnumerator<TElement> GetEnumerator()
        {
            // First copy the elements into an array: don't bother with a list, as we
            // want to use arrays for all the swapping around.
            int count;
            TElement[] data = source.ToBuffer(out count);

            int[] indexes = new int[count];
            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = i;
            }

            TCompositeKey[] keys = new TCompositeKey[count];
            for (int i = 0; i < keys.Length; i++)
            {
                keys[i] = compositeSelector(data[i]);
            }

            int nextYield = 0;

            var stack = new Stack<LeftRight>();
            stack.Push(new LeftRight(0, count - 1));
            while (stack.Count > 0)
            {
                LeftRight leftRight = stack.Pop();
                int left = leftRight.left;
                int right = leftRight.right;
                if (right > left)
                {
                    // Note: not just (left + right) / 2 in order to avoid a common bug: http://goo.gl/d4d4
                    int pivot = left + (right - left) / 2;
                    int pivotPosition = Partition(indexes, keys, left, right, pivot);
                    // Push the right sublist first, so that we *pop* the
                    // left sublist first
                    stack.Push(new LeftRight(pivotPosition + 1, right));
                    stack.Push(new LeftRight(left, pivotPosition - 1));
                }
                else
                {
                    while (nextYield <= right)
                    {
                        yield return data[indexes[nextYield]];
                        nextYield++;
                    }
                }
            }
        }

        private struct LeftRight
        {
            internal readonly int left, right;
            internal LeftRight(int left, int right)
            {
                this.left = left;
                this.right = right;
            }
        }

        private int Partition(int[] indexes, TCompositeKey[] keys, int left, int right, int pivot)
        {
            // Remember the current index (into the keys/elements arrays) of the pivot location
            int pivotIndex = indexes[pivot];
            TCompositeKey pivotKey = keys[pivotIndex];

            // Swap the pivot value to the end
            indexes[pivot] = indexes[right];
            indexes[right] = pivotIndex;
            int storeIndex = left;
            for (int i = left; i < right; i++)
            {
                int candidateIndex = indexes[i];
                TCompositeKey candidateKey = keys[candidateIndex];
                int comparison = compositeComparer.Compare(candidateKey, pivotKey);
                if (comparison < 0 || (comparison == 0 && candidateIndex < pivotIndex))
                {
                    // Swap storeIndex with the current location
                    indexes[i] = indexes[storeIndex];
                    indexes[storeIndex] = candidateIndex;
                    storeIndex++;
                }
            }
            // Move the pivot to its final place
            int tmp = indexes[storeIndex];
            indexes[storeIndex] = indexes[right];
            indexes[right] = tmp;
            return storeIndex;
        }
    }
}
