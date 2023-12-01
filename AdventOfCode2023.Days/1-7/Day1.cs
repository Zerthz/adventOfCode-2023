using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Days._1_7
{
    public static class Day1
    {
        private static readonly string _filePath = "Files/1-7/Day1.txt";
        //private static readonly string _testFilePath = "Files/1-7Tests/Day1.test.txt";
        public static int Run()
        {
            int output = 0;
            using (StreamReader sr = new StreamReader(_filePath))
            {
                string line;
                while ((line = sr.ReadLine()!) != null)
                {
                    // Perform your tests here
                    var digits = string.Concat(line.Where(Char.IsDigit));
                    string doubleDigit = "";
                    doubleDigit += digits.First();
                    doubleDigit += digits.Last();
                    output += int.Parse(doubleDigit);
                }
            }

            return output;
        }
    }
}
