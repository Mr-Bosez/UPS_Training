namespace ConsoleApp1.Day_7
{
    internal class PrimeNumbersIn2D
    {
        public void printPrimeNumbersIn2D()
        {
            Console.WriteLine("Enter the no of rows of the array: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no of columns of the array: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[rows, cols];
            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The prime numbers in the array are: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    bool isPrime = true;
                    if (arr[i, j] <= 1)
                        isPrime = false;
                    else
                    {
                        for (int k = 2; k <= arr[i, j] / 2; k++)
                        {
                            if (arr[i, j] % k == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if (isPrime)
                        Console.Write(arr[i, j] + " ");
                }
                //Console.WriteLine();
            }

        }
    }
}
