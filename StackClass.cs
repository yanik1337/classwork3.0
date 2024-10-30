namespace ClassWork5.StackClass
{
    public class Stack<T>
    {
        private List<T> _items = new List<T>();

        public void Push(T item)
        { 
            _items.Add(item);
        }

        public T Pop()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("пустой стек(");
            }
            T lastItem = _items[_items.Count - 1];
            _items.RemoveAt(_items.Count - 1);
            return lastItem;
        }
    }
}
