using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2


{


public interface IGenericList<X>
{

    void Add(X item);

    bool Remove(X item);

    bool RemoveAt(int index);

    X GetElement(int index);

    int IndexOf(X item);

    int Count();

    void Clear();

    bool Contains(X item);
}  

public class X
    {
        public int broj { get; set; }
    }

    public class GenericList<X> : IGenericList<X>
    {
        private X[] _internalStorage;
        private int counter=0;

        public GenericList()
        {
            _internalStorage = new X[4];

        }

        public GenericList(int initialSize)
        {
            if (initialSize <= 0)
            {
                _internalStorage = new X[4];
            }
            else
            {
                _internalStorage = new X[initialSize];
            }

        }


        public void Add(X item)
        {
            if (counter == _internalStorage.Length)
            {
                Array.Resize(ref _internalStorage, (_internalStorage.Length) * 2);
                _internalStorage[counter] = item;
                counter++;
            }

            else
            {
                _internalStorage[counter] = item;
                counter++;
            }
        }


        public bool Remove(X item)
        {
            for (int i = 0; i < counter; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return RemoveAt(i);
                }
            }
            return false;
        }


        public bool RemoveAt(int index)
        {
            if ((index < 0) || (index > (counter - 1)))
            {
                return false;
            }
            if (index == (counter - 1))
            {
                counter--;
                return true;
            }
            else
            {
                for (int j = index; j < (counter - 2); j++)
                {
                    _internalStorage[j] = _internalStorage[j + 1];
                }

                counter--;
                return true;
            }

        }

        public X GetElement(int index)
        {

            {
                if ((index >= 0) && (index <= _internalStorage.Length))
                {
                    return _internalStorage[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();

                }
            }

        }


        public int IndexOf(X item)
        {
            for (int i = 0; i < counter; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;

        }

        public int Count()
        {
            return counter;
        }





        public void Clear()
        {
            counter = 0;
        }

        public bool Contains(X item)
        {
            for (int i = 0; i < counter; i++)
            {
                if (_internalStorage[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
