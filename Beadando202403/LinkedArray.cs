using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando202403
{
    public class LinkedArray
    {
        private object[,] data;
        public int count { get; private set; } = 0; // mennyi tombot tarolunk
        public int size { get; private set; } // mekkorak a tarolt tombok

        public LinkedArray(int size)
        {
            count++;
            this.size = size;
            data = new object[count,size];
        }

        public object GetElement(int index)
        {
            return data[index,size];
        }

        public void SetElement(int index, object value)
        {                    
            data[index,size] = value;         
        }

        public void Clear()
        {
            count = 1;
            data = new object[count,size];
        }

        public void SetZero()
        {
            size = 0;
        }

        public void NewRow()
        {
            object[,] temp = new object[count,size];
            for (int i = 0; i < count; i++)
            {
                temp[i,size] = data[i,size];
            }
            count++;
            data = new object[count,size];
            data = temp;
        }
    }
}
