using System;
using System.IO;
using System.Linq;

namespace LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("../../../TextFile1.txt");

            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                int countOfLetters = CountOfLetters(line);
                int countOfMarks = CountOfPunctuationMarks(line);

                result[i] = $"Line {i + 1}: {lines[i]}({countOfLetters})({countOfMarks})";
            }

            File.WriteAllLines("../../../output.txt", result);


        }
        static int CountOfLetters(string line)
        {
            int counter = 0;
            for (int i = 0; i < line.Length; i++)
            {
                char symbol = line[i];
                if (char.IsLetter(symbol))
                {
                    counter++;
                }
            }
            return counter;
        }
        static int CountOfPunctuationMarks(string line)
        {
            int counter = 0;
            char[] punctuationMarks = { '-', ',', '.', '\'', '?', '!' };

            for (int i = 0; i < line.Length; i++)
            {
                char symbol = line[i];
                if (punctuationMarks.Contains(symbol))
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
