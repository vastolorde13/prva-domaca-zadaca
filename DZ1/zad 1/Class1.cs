using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int counter = 0;

        public IntegerList()
        {
            _internalStorage = new int[4];


            Console.WriteLine("prvi konstruktor");
        }

        public IntegerList(int initialSize)
        {
            if (initialSize <= 0)
            {
                _internalStorage = new int[4];
            }
            _internalStorage = new int[initialSize];
        }

        public void Add(int item)
        {
            if (_internalStorage.Length == counter)
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


        public bool Remove(int item)
        {
            for (int i = 0; i < counter; i++)
            {
                if (_internalStorage[i] == item)
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

        public int GetElement(int index)
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


        public int IndexOf(int item)
        {
            for (int i = 0; i < counter; i++)
            {
                if (_internalStorage[i] == item)
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

        public bool Contains(int item)
        {
            for (int i = 0; i < counter; i++)
            {
                if (_internalStorage[i] == item)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public interface IIntegerList
    {

        void Add(int item);

        bool Remove(int item);

        bool RemoveAt(int item);

        int GetElement(int index);

        int IndexOf(int item);



        void Clear();

        bool Contains(int item);


    }
}
