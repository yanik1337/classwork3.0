namespace ClassWork5.ObjectExtenseClass
{
    public class ObjectExtense
    {
        public static bool AreEqual<T>(T item1, T item2)
        {
            if  (item1 == null && item2 == null)
            {
                return true;
            }

            if (item1 == null || item2 == null)
            {
                return true;
            }
            return item1.Equals(item2);
        }
    }
}
