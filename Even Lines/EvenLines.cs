using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Even_Lines
{
    class EvenLines
    {
        static void Main(string[] args)
        {
            //1. Read a file
           using StreamReader reader= new StreamReader("../../../text.txt");
            using var writer = new StreamWriter("../../../output.txt");
            string line = reader.ReadLine();
            int lineCounter = 0;

            while (line!=null)
            {
                if (lineCounter%2==0)
                {
                    Regex pattern = new Regex("[-,.'?!]");
                    line = pattern.Replace(line,"@");

                    var array = line.Split().ToArray().Reverse();
                    writer.WriteLine(string.Join(" ",array));
                }
                lineCounter++;
                line = reader.ReadLine();
            }
        }
    }
}
