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

        public static void MoveUp<T>(this BindingList<T> list, int index)
        {
            int newIndex = index - 1;
            if (newIndex != -1)
            {
                var item = list[index];
                list.RemoveAt(index);
                list.Insert(newIndex, item);
            }
        }
        public static void MoveDown<T>(this BindingList<T> list, int index)
        {
            int newIndex = index + 1;
            if (newIndex != list.Count)
            {
                var item = list[index];
                list.RemoveAt(index);
                list.Insert(newIndex, item);
            }
        }
    }
}
