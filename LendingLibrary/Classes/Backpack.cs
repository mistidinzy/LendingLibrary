using System;
using System.Collections;
using System.Collections.Generic;

namespace LendingLibrary.Classes
{
    public class Backpack<T> : IBag<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Pack(T item)
        {
            throw new NotImplementedException();
        }

        public T Unpack(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
