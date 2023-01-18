namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 6, 7, 13, 10, 3, 9, 5, 1 };
            arr = MergeSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static int[] MergeSort(int[] arr)
        {
            if (arr.Length == 1)
                return arr;

            bool two = false;
            if (arr.Length%2!=0)
                two = true;

            int d = arr.Length / 2;
            int d2 = d;
            if (two)
                d2++;

            int[] arr1 = new int[d];
            int[] arr2 = new int[d2];
            for (int i = 0; i < d; i++)
            {
                arr1[i] = arr[i];
                arr2[i] = arr[i + d];
            }
            if (two)
                arr2[arr2.Length - 1] = arr[arr.Length - 1];

            arr1 = MergeSort(arr1);
            arr2 = MergeSort(arr2);
            return Sorting(arr1, arr2);
        }
        static int[] Sorting(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            for (int i = 0, j = 0; ;)
            {
                if (arr1[i] < arr2[j])
                {
                    arr[j + i] = arr1[i];
                    i++;
                }
                else
                {
                    arr[j + i] = arr2[j];
                    j++;
                }
                if (i==arr1.Length)
                {
                    while (j<arr2.Length)
                    {
                        arr[j + i] = arr2[j];
                        j++;
                    }
                    break;
                }
                if (j == arr2.Length)
                {
                    while (i < arr1.Length)
                    {
                        arr[j + i] = arr1[i];
                        i++;
                    }
                    break;
                }
            }
            return arr;
        }
    }
}