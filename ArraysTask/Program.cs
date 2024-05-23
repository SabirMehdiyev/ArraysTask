namespace ArraysTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            int[] arr = { 1, 2, 3, 4, 5 };

            int n = arr.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int num = arr[i];
                arr[i] = arr[n - 1 - i];
                arr[n - 1 - i] = num;
            }

            Console.Write("Reversed array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            #endregion

            #region Task2
            int[] arr1 = { 1, 2, 3, 4, 9 };
            int[] arr2 = { 5, 4, 3, 2, 1, 6, 7 };

            bool containsAll = true;


            if (arr2.Length < arr1.Length)
            {
                containsAll = false;
            }
            else
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    bool found = false;
                    for (int j = 0; j < arr2.Length; j++)
                    {
                        if (arr2[j] == arr1[i])
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        containsAll = false;
                        break;
                    }
                }
            }

            Console.WriteLine("Result " + containsAll);
            #endregion

            #region Task3

            int[] numbers = { 1, 2, 3, 3, 5, 6 };

            bool foundDuplicate = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    Console.WriteLine("Duplicate found");
                    foundDuplicate = true;
                    break;
                }
            }

            if (!foundDuplicate)
            {
                Console.WriteLine("No duplicates found.");
            }
            #endregion
        }

    }

}

