using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando202403
{
    public class LinkedArray<T>
    {
        private T[][] data;
        public int count { get; private set; } = 0; // mennyi tombot tarolunk
        public int size { get; private set; } // mekkorak a tarolt tombok

        public LinkedArray(int size)
        {
            count++;
            data = new T[count][];
            this.size = size;
        }

        public T[] GetElement(int index)
        {
            if(index < count)
            {
                return data[index];
            }
            else
            {
                Console.WriteLine("Out of bounds");
                return null;
            }
        }

        public void SetElement(int index, T[] value)
        {
            if(index > count)
            {
                Console.WriteLine("Too big index");
                return;
            }
            if(value.Length > size)
            {
                Console.WriteLine("Too big array");
                return;
            }

            data[index] = value;           
        }

        public void Clear()
        {
            count = 1;
            data = new T[count][];
        }

        public void SetZero()
        {
            size = 0;
        }

        public void NewRow()
        {
            count++;

        }
    }
}
