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
            Console.WriteLine("5. Get the total size of the LinkedArray");
            Console.WriteLine("6. Clear the LinkedArray");
            Console.WriteLine("7. Set the size of the LinkedArray to zero");
            Console.WriteLine("8. Add new row to the LinkedArray");
            Console.WriteLine("9. Resize LinkedArray");
            Console.WriteLine("10. Populate LinkedArray");
            Console.WriteLine("11. Add first row to LinkedArray");
            Console.WriteLine("12. Get not null elements of LinkedArray");
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
                    case 5:
                        GetSizeLinkedArray();
                        break;
                    case 6:
                        ClearLinkedArray();
                        break;
                    case 7:
                        SetZeroLinkedArray();
                        break;
                    case 8:
                        AddNewRow();
                        break;
                    case 9:
                        ReSizeLinkedArray();
                        break;
                    case 10:
                        PopulateLinkedArray();
                        break;
                    case 11:
                        AddFirstRow();
                        break;
                    case 12:
                        GetNotNull();
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
                    throw new Exception("Wrong input!");
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
                linkedArray.Print();
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();
        }

        private void SetElementLinkedArray()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Set an element in the LinkedArray");
                Console.WriteLine($"Index? (0-{linkedArray.Size - 1})");
                bool valid = int.TryParse(Console.ReadLine(), out int index);
                if (!valid)
                {
                    throw new Exception("Wrong input!");
                }
                Console.WriteLine("Value?");
                linkedArray.SetElement(index, Console.ReadLine());
                Console.WriteLine("Successfully set");
                Thread.Sleep(1000);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(1000);
                SetElementLinkedArray();
            }

        }

        private void GetElementLinkedArray()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Get an element from the LinkedArray");
                Console.WriteLine($"Index? (0-{linkedArray.Size - 1})");
                bool valid = int.TryParse(Console.ReadLine(), out int index);
                if (!valid)
                {
                    throw new Exception("Wrong input!");
                }
                Console.WriteLine(linkedArray.GetElement(index));
                Console.WriteLine("Press Enter to Exit");
                Console.ReadKey();
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(1000);
                GetElementLinkedArray();
            }

        }

        private void GetSizeLinkedArray()
        {
            Console.Clear();
            if(linkedArray == null)
            {
                Console.WriteLine("You don't have a LinkedArray");
            }else
            {
                Console.WriteLine($"The total size of the LinkedArray is {linkedArray.TotalSize()}");
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();
        }

        private void ClearLinkedArray()
        {
            Console.Clear();
            if(linkedArray == null)
            {
                Console.WriteLine("You don't have a LinkedArray");
            }
            else
            {
                linkedArray.Clear();
                Console.WriteLine("LinkedArray successfully cleared");
            }          
            Thread.Sleep(1000); ;
        }

        private void SetZeroLinkedArray()
        {
            Console.Clear();
            if(linkedArray == null)
            {
                Console.WriteLine("You don't have a LinkedArray");
            }
            else
            {
                linkedArray.SetZero();
                Console.WriteLine("LinkedArray's size is set to zero");
            }
            Thread.Sleep(1000);
        }

        private void AddNewRow()
        {
            Console.Clear();
            if(linkedArray == null)
            {
                Console.WriteLine("You don't have a LinkedArray");
            }
            else
            {
                linkedArray.NewRow();
                Console.WriteLine("New row added to LinkedArray");
            }
            Thread.Sleep(1000);
        }

        private void ReSizeLinkedArray()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("New size of the LinkedArray?");
                bool valid = int.TryParse(Console.ReadLine(), out int size);
                if (!valid)
                {
                    throw new Exception("Wrong input!");
                }
                linkedArray.ReSize(size);
                Console.WriteLine("LinkedaArray successfully resized");
                Thread.Sleep(1000);
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(1000);
                ReSizeLinkedArray();
            }            
        }
        
        private void PopulateLinkedArray()
        {
            Console.Clear();
            if(linkedArray == null)
            {
                Console.WriteLine("You don't have a LinkedArray");
            }else
            {
                linkedArray.Populate();
                Console.WriteLine("Successfully populated the LinkedArray");
            }
            Thread.Sleep(1000);
        }

        private void AddFirstRow()
        {
            Console.Clear();
            if (linkedArray == null)
            {
                Console.WriteLine("You don't have a LinkedArray");
            }
            else
            {
                linkedArray.NewFirstRow();
                Console.WriteLine("Successfully added new first row");
            }
            Thread.Sleep(1000);
        }

        private void GetNotNull()
        {
            Console.Clear();
            if (linkedArray == null)
            {
                Console.WriteLine("You don't have a LinkedArray");
            }
            else
            {
                Console.WriteLine($"Number of not null elements {linkedArray.NotNull()}");
            }
            Console.WriteLine("Press Enter to Exit");
            Console.ReadKey();
        }
    }
}
