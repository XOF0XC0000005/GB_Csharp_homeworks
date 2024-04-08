namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDimensionalArray = 
                { 
                    { 7, 3, 2 }, 
                    { 4, 9, 6 }, 
                    { 1, 8, 4 },
                };
            int[] oneDimensionalArray = new int[twoDimensionalArray.Length];;
            int counter = 0;

            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    oneDimensionalArray[counter] = twoDimensionalArray[i, j];
                    counter++;
                }
            }

            Array.Sort(oneDimensionalArray);
            counter = 0;

            for (int i = 0; i < twoDimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < twoDimensionalArray.GetLength(1); j++)
                {
                    twoDimensionalArray[i, j] = oneDimensionalArray[counter];
                    counter++;
                    Console.Write(twoDimensionalArray[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
