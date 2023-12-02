using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023.Days._1_7
{
    public static class Day2
    {
        private static string _filePath = "Files/1-7/Day2.txt";
        //private static string _testPath = "Files/1-7Tests/Day2Test.txt";
        public static int Run()
        {
            int sum = 0;
            using (StreamReader sr = new StreamReader(_filePath))
            {
                string line;
                while ((line = sr.ReadLine()!) != null)
                {
                    int id = GetId(line);
                    if(!CheckRounds(line))
                    {
                        sum += id;
                    }

                }
            }
            return sum;

        }
        private static int GetId(string line)
        {
            // The ID is after the first space and before the first colon.
            int spaceIndex = line.IndexOf(' ');
            int colonIndex = line.IndexOf(':');
            string id = line.Substring(spaceIndex + 1, colonIndex - spaceIndex - 1);
            return int.Parse(id);
        }
        private static bool CheckRounds(string line)
        {
            // Rounds are after the first colon, and separated by semicolons. Each round is a list of and ints colors separated by comas
            int colonIndex = line.IndexOf(':');
            string gameString = line.Substring(colonIndex + 1);
            var roundsArr = gameString.Split(';');
            
            foreach (var round in roundsArr)
            {
                // Each round is of the pattern "number color, number color, number color"
                var shownPlusColors = round.Split(',');
                foreach (var shownPlusColor in shownPlusColors)
                {
                    var arr = shownPlusColor.Split(' ');
                    if ((arr[2] == "red" && int.Parse(arr[1]) > 12) ||
                        (arr[2] == "green" && int.Parse(arr[1]) > 13) ||
                        (arr[2] == "blue" && int.Parse(arr[1]) > 14))
                    {
                        return true;
                    }
                }               
            }
            return false;
        }
    }


    
}
