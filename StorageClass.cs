using ClassWork5.IContainerInterface;

namespace ClassWork5.StorageClass
{
    public class Storage<T> : IContainer<T>
    {
        private T _item;

        public void AddItem(T item)
        {
            _item = item;
        }

        public T GetItem()
        {
            return _item;
        }
    }
}
