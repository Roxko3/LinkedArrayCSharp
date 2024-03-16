﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando202403
{
    public class LinkedArray
    {
        private object[,] data;
        public int Count { get; private set; } = 1; // mennyi tombot tarolunk | m
        public int Size { get; private set; } // mekkorak a tarolt tombok | n

        public LinkedArray(int size)
        {
            this.Size = size;
            data = new object[Count, size];
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
            object[,] temp = new object[Count, Size];
            for (int i = 0; i < Count; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    temp[i,j] = data[i,j];
                }
            }
            Count++;
            data = new object[Count, Size];
            data = temp;
        }

        public void ReSize(int newSize)
        {            
            if(newSize < Size)
            {
                throw new Exception("New size can't be smaller");
            }
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

        public void PrintData()
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
