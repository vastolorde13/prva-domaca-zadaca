using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ZAD3
{
    public class GenericListEnumerator<T> : IEnumerator<T>
    {
        IGenericList<T> _collection;
        int index = 0;
        public GenericListEnumerator(IGenericList<T> collection)
        {
            _collection = collection;
        }
        public bool MoveNext()
        {
            if (index < _collection.Count) return true;
            return false;
            
        }
        public T Current
        {
            get
            {
                return _collection.GetElement(index++);
                
            }
        }

        object IEnumerator.Current { get { return Current; } }

        public void Dispose()
        {
           
        }
        public void Reset()
        {
           
        }
    }
}
