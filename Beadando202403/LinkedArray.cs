﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando202403
{
    public class InvalidSizeException : Exception { public InvalidSizeException(string message): base(message) { } }

    public class LinkedArray
    {
        private object[,] data;
        public int Count { get; private set; } = 1; // mennyi tombot tarolunk | m
        public int Size { get; private set; } = 0; // mekkorak a tarolt tombok | n

        public LinkedArray(int size)
        {
            if(size < 1)
            {
                throw new InvalidSizeException("Size can't be smaller than 1");
            }
            this.Size = size;
            data = new object[Count, size];
        }

        public LinkedArray()
        {
            data = new object[Count, Size];
        }

        public object GetElement(int index)
        {
            return data[Count - 1,index];
        }

        public void SetElement(int index, object value)
        {
            data[Count - 1, index] = value;         
        }

        public int TotalSize()
        {
            return Count * Size;
        }

        public void Clear()
        {
            data = new object[Count, Size];
        }

        public void SetZero()
        {
            Size = 0;
        }

        public void NewRow()
        {
            Count++;
            object[,] temp = new object[Count, Size];
            for (int i = 0; i < Count-1; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    temp[i,j] = data[i,j];
                }
            }        
            data = new object[Count, Size];
            data = temp;
        }

        public void ReSize(int newSize)
        {            
            if(newSize < Size && NotNull() != 0)
            {
                throw new InvalidSizeException("New size can't be smaller than old");
            }
            if(NotNull() == 0)
            {
                this.Size = newSize;
                data = new object[Count, Size];
            } 
            else
            {
                object[,] temp = new object[Count, newSize];
                for (int i = 0; i < Count; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        temp[i, j] = data[i, j];
                    }
                }
                this.Size = newSize;
                data = new object[Count, Size];
                data = temp;
            }
        }

        public void Print()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    Console.Write($"{data[i,j]} ");
                }
                Console.WriteLine();
            }
        }

        public object[,] GetData()
        {
            return data;
        }

        public void Populate()
        {
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    data[i, j] = "Data "+(i+j);
                }
            }
        }

        public void NewFirstRow()
        {
            object[,] temp = new object[Count+1, Size];
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    temp[i+1,j] = data[i,j];
                }
            }
            Count++;
            data = new object[Count,Size];
            data = temp;
        }

        public int NotNull()
        {
            int c = 0;
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (data[i,j] != null)
                    {
                        c++;
                    }
                }
            }
            return c;
        }
    }
}
