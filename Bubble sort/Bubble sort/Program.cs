namespace Bubble_sort
{
    internal class Program
    {
        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if(arr[j] > arr[j +1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j +1];
                        arr[j +1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine("Numebers : " + i);
            }
        }
        static void Main(string[] args)
        {
            int[] numbers = { 20, 3, 15, 87, 65, 15, 33, 97, 5, 35 };

            Console.WriteLine("After sorting : ");
            PrintArray(numbers);

            BubbleSort(numbers);
            Console.WriteLine("After Sorting");
            PrintArray(numbers);
        }  
    }
}
