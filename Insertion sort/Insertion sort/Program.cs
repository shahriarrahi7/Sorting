namespace Insertion_sort
{
    internal class Program
    {
        static void InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int current = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] >= current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = current;
            }
        }
        static void printArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine("Numbers : " + i);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 11, 5, 78, 65, 20, 49, 66, 88 };
            Console.WriteLine("Before sorting :");
            printArray(numbers);


            InsertionSort(numbers);
            Console.WriteLine("After sorting");
            printArray(numbers);
        }
    }
}
