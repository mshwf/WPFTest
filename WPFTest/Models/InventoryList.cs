using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Models
{
    public class InventoryList : IList<Inventory>, INotifyCollectionChanged
    {
        readonly IList<Inventory> _inventories;
        public InventoryList(IList<Inventory> inventories)
        {
            _inventories = inventories;
        }
        public Inventory this[int index]
        {
            get { return _inventories[index]; }
            set { _inventories[index] = value; }
        }

        public int Count => _inventories.Count;

        public bool IsReadOnly => _inventories.IsReadOnly;

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        public void Add(Inventory item)
        {
            _inventories.Add(item);
            OnCollectionChanged(new  NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));
        }

        public void Clear()
        {
            _inventories.Clear();
        }

        public bool Contains(Inventory item) => _inventories.Contains(item);

        public void CopyTo(Inventory[] array, int arrayIndex)
        {
            _inventories.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Inventory> GetEnumerator() => _inventories.GetEnumerator();

        public int IndexOf(Inventory item) => _inventories.IndexOf(item);

        public void Insert(int index, Inventory item)
        {
            _inventories.Insert(index, item);
            OnCollectionChanged(new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item, index));
        }

        public bool Remove(Inventory item) => _inventories.Remove(item);


        public void RemoveAt(int index)
        {
            _inventories.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            CollectionChanged?.Invoke(this, args);
        }
    }
}
