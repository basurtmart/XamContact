using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace XamContacts.Helpers
{
    public class Gruping<K, T> : ObservableCollection<T>
    {
        public K Key { get; set; }

        public Gruping(K key, IEnumerable<T> items)
        {
            Key = key;
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
