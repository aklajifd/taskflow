using System;
using System.Collections.Generic;
using System.Linq;
using Taskflow.Console.Interfaces;

namespace Taskflow.Console.Repositories
{
    public class Repository<T> where T : class, IEntity
    {
        private List<T> _items = new List<T>();
        private int _nextId = 1;

        public void Add(T item)
        {
            item.Id = _nextId++;
            _items.Add(item);
        }

        public List<T> GetAll() => _items;

        public T? GetById(int id) => Find(t => t.Id == id);

        public void Delete(int id)
        {
            T? itemToRemove = GetById(id);
            if (itemToRemove is not null)
            {
                _items.Remove(itemToRemove);
            }
        }

        public int Count => _items.Count;

        public T? Find(Func<T, bool> predicate)
        {
            return _items.FirstOrDefault(predicate);
        }

        public List<T> Filter(Func<T, bool> predicate)
        {
            return _items.Where(predicate).ToList();
        }

        public List<T> GetAllOrdered<TKey>(Func<T, TKey> keySelector)
        {
            return _items.OrderBy(keySelector).ToList();
        }

        public bool Exists(Func<T, bool> predicate)
        {
            return _items.Any(predicate);
        }

        public int CountWhere(Func<T, bool> predicate)
        {
            return _items.Count(predicate);
        }
    }
}