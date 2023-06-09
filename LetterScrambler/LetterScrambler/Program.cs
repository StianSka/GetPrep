namespace LetterScrambler
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a word:");
            string input = Console.ReadLine();

            List<string> combinations = GenerateCombinations(input);

            Console.WriteLine("All possible combinations:");
            foreach (string combination in combinations)
            {
                Console.WriteLine(combination);
            }

            Console.ReadLine();
        }
        static List<string> GenerateCombinations(string input)
        {
            List<string> combinations = new List<string>();
            char[] letters = input.ToCharArray();

            // Generate combinations using recursion
            GenerateCombinationsRecursive(letters, combinations, 0, letters.Length - 1);

            return combinations;
        }
        static void GenerateCombinationsRecursive(char[] letters, List<string> combinations, int start, int end)
        {
            if (start == end)
            {
                combinations.Add(new string(letters));
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    Swap(ref letters[start], ref letters[i]);
                    GenerateCombinationsRecursive(letters, combinations, start + 1, end);
                    Swap(ref letters[start], ref letters[i]); // Backtrack
                }
            }
        }
        static void Swap(ref char a, ref char b)
        {
            char temp = a;
            a = b;
            b = temp;
        }
    }
}