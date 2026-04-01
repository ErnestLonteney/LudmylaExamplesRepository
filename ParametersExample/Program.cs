namespace ParametersExample
{
    internal class Program
    {
        private static bool IsExist (char[] symbols, char templete, out int index, out int counter)
        {
            counter = 0;
            index = -1;

            symbols = ['*', '*', '*'];

            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == templete)
                {
                    if (index == -1)
                    {
                        index = i;
                    }

                    counter++;
                }
            }

            return counter > 0;
        }

        static void Main(string[] args)
        {
            char[] word = ['H', 'e', 'l', 'l', 'o']; //AA34
            IsExist(word, 'l', out int startIndex, out int meetCount);

            Console.WriteLine(startIndex);
            Console.WriteLine(meetCount);
        }
    }
}
