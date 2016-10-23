using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ZAD3
{
    public interface IGenericList<X> : IEnumerable<X>
    {
        
        void Add(X item);
        
        bool Remove(X item);
        
        bool RemoveAt(int index);
        
        X GetElement(int index);
        
        int IndexOf(X item);
        
        int Count { get; }
        
        void Clear();
        
        bool Contains(X item);
    }


    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int _count = 0;

        public GenericList()
        {
            _internalStorage = new X[4];
        }

        public GenericList(int initialSize)
        {
            _internalStorage = new X[initialSize];
        }

        
        public void Add(X item)
        {
            if (_count >= _internalStorage.Length)
            {
               
                Array.Resize<X>(ref _internalStorage, _count * 2);
            }
            _internalStorage[_count] = item;
            _count++;
        }
        
        public bool Remove(X item)
        {
            int index = IndexOf(item);
            if (index > 0) RemoveAt(index);

            return false;
        }
        
        public bool RemoveAt(int index)
        {
            if (index > (_count - 1))
            {
                
                return false;
            }
           
            for (int i = index; i < _count - 1; i++)
            {
                _internalStorage[i] = _internalStorage[i + 1];
            }
            _count--;
            return true;
        }
        /// <summary>
        
        public X GetElement(int index)
        {
            if (index < _count)
            {
                return _internalStorage[index];
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        
        public int IndexOf(X item)
        {
            for (int i = 0; i < _count; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    
                    return i;
                }
            }

            
            return -1;
        }
        
        public int Count
        {
            get
            {
                return _count;
            }
        }
        
        public void Clear()
        {
            _count = 0;
        }
        
        public bool Contains(X item)
        {
            if (IndexOf(item) >= 0) return true;

           
            return false;
        }

        public IEnumerator<X> GetEnumerator()
        {
            return new GenericListEnumerator<X>(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }

}


