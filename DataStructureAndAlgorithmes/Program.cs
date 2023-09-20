namespace DataStructureAndAlgorithmes
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter the number you want to guess: ");
                int number = int.Parse(Console.ReadLine());

                //Console.Write("Please enter a list of numbers: ");
                //// Split the input string into an array of strings based on spaces
                ////string[] numberStrings = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                //string[] numberStrings = Console.ReadLine().Split(' ');


                //// Convert the string array to a list of integers
                //List<int> numbers = numberStrings.Select(int.Parse).ToList();

                Console.WriteLine($"index of number is {FindNumberInList(new List<int> { 20, 18, 16, 10, 8, 6, 4, 2, 1 }, number)}");

                Console.WriteLine("\n###################################\n");
            }
        }
        public static int FindNumberInList(List<int> listNumbers, int number)
        {
            int loweIndex = 0;
            int higheIndex = listNumbers.Count - 1;
            while (higheIndex >= loweIndex)
            {
                int midIndex = (loweIndex + higheIndex) / 2;

                if (listNumbers[midIndex] == number)
                    return midIndex + 1;

                if (listNumbers[midIndex] > number)
                    loweIndex = midIndex + 1;

                else
                    higheIndex = midIndex - 1;

            }
            return -1;
        }
    }
}