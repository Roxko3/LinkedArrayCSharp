using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando202403
{
    public class Menu
    {
        private LinkedArray linkedArray;

        public Menu()
        {         
            Loop();
        }

        public void Loop()
        {
            Console.Clear();
            Console.WriteLine("LinkedArray Menu");
            Console.WriteLine("1. Create LinkedArray");
            Console.WriteLine("2. List elements from LinkedArray");
            Console.WriteLine("3. Set Element in LinkedArray");
            Console.WriteLine("4. Get Element from LinkedArray");
            Console.WriteLine("0. Exit");

            bool valid = int.TryParse(Console.ReadLine(), out int input);

            if (valid)
            {
                switch (input)
                {
                    case 1:
                        CreateLinkedArray();
                        break;
                    case 2:
                        ListLinkedArray();
                        break;
                    case 3:
                        SetElementLinkedArray();
                        break;
                    case 4:
                        GetElementLinkedArray();
                        break;
                    case 0:
                        return;
                    default:
                        break;
                }
            }

            Loop();
        }
        
        private void CreateLinkedArray()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Create LinkedArray");
                Console.WriteLine("Enter the size of the inner arrays:");
                bool valid = int.TryParse(Console.ReadLine(), out int input);
                if (!valid)
                {
                    throw new Exception("Wrong input");
                }
                linkedArray = new LinkedArray(input);
                Console.WriteLine("Successfully Created");
                Thread.Sleep(1000);

            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(1000);
                CreateLinkedArray();
            }
        }

        private void ListLinkedArray()
        {
            Console.Clear();
            Console.WriteLine("Listing the contents of the LinkedArray");
            if(linkedArray == null)
            {
                Console.WriteLine("You don't have a LinkedArray");
            }
            else
            {
                for (int i = 0; i < linkedArray.Size; i++)
                {
                    Console.WriteLine(linkedArray.GetElement(i));
                }
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();
        }

        private void SetElementLinkedArray()
        {
            Console.Clear();
            Console.WriteLine("Set an element in the LinkedArray");
            Console.WriteLine($"Index? (0-{linkedArray.Size-1})");
            int.TryParse(Console.ReadLine(),out int index);
            Console.WriteLine("Value?");
            linkedArray.SetElement(index,Console.ReadLine());
            Console.WriteLine("Successfully set");
            Thread.Sleep(1000);
        }

        private void GetElementLinkedArray()
        {
            Console.Clear();
            Console.WriteLine("Get an element from the LinkedArray");
            Console.WriteLine($"Index? (0-{linkedArray.Size - 1})");
            int.TryParse(Console.ReadLine(),out int index);
            Console.WriteLine(linkedArray.GetElement(index));
            Thread.Sleep(1000);
        }
    }
}
