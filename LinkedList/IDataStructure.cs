using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal interface IDataStructure <T>
    {
        public void Insert (T item);
        public void Remove(T item);
        public bool Find(T item);

    }
}
