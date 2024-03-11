namespace Beadando202403
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedArray<int> test = new LinkedArray<int>(3);

            int[] tomb = { 1, 2, 3, 4 ,5};
            test.SetElement(0, tomb);

            Console.WriteLine(test.GetElement(0));
        }
    }
}