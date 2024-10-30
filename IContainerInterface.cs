namespace ClassWork5.IContainerInterface
{
    public interface IContainer<T>
    {
        void AddItem(Task item);
        T GetItem<T>();
    }
}
