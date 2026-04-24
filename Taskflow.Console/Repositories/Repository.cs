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

        public T? GetById(int id)
        {
            foreach(T item in _items)
            {
                if (item.Id == id) return item;
                
            }
            return null;
        }

        public void Delete(int id)
        {
            T? itemToRemove = GetById(id);
            if (itemToRemove is not null)
            {
                _items.Remove(itemToRemove);
            }
        }

        public int Count => _items.Count;
    }
}