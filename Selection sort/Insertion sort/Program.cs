namespace Insertion_sort
{
    internal class Program
    {
        static void Insertion(int[]arr)
        {
            int n = arr.Length;

            for(int i = 0; i < n -1 ; i++)
            {
                int MaXArray = i;
                for(int j = i+1; j < n ; j++)
                {
                    if( arr[j] < arr[MaXArray])
                    {
                        MaXArray = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[MaXArray];
                arr[MaXArray] = temp;
            }
        }

        static void PrintArray(int[]arr)
        {
            foreach(int i in arr)
            {
                Console.WriteLine("Numbers : " + i);
            }
        }

        static void Main(string[] args)
        {
            int[] numbers = { 20, 3, 15, 87, 65, 15, 33, 97, 5, 35 };

            Console.WriteLine("After sorting : ");
            PrintArray(numbers);

            Insertion(numbers);
            Console.WriteLine("After Sorting");
            PrintArray(numbers);
        }
    }
}
