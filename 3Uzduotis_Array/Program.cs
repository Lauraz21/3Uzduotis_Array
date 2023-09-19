namespace _3Uzduotis_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] randomNumbers = { 2, 5, 9, 4, 7 };
            

            for (int i = 0; i < randomNumbers.Length - 1; i++)
            {
                for (int j = 0; j < randomNumbers.Length - (1 + i); j++)
                {
                    if (randomNumbers[j] > randomNumbers[j + 1])
                    {

                        int temp = randomNumbers[j + 1];
                        randomNumbers[j + 1] = randomNumbers[j];
                        randomNumbers[j] = temp;
                    }
                }
            }
            for (int k = 0;  k < randomNumbers.Length;  k++)
            {
                Console.WriteLine(randomNumbers[k]);
            }
        }
    }
}