namespace HTML_CREATOR
{
    using System.Collections.Generic;
    using System.ComponentModel;
    static class BindingListExtensions
    {
        public static void AddRange<T>(this BindingList<T> list, IEnumerable<T> data)
        {
            if (list == null || data == null)
            {
                return;
            }

            foreach (T t in data)
            {
                list.Add(t);
            }
        }
    }
}
