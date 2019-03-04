using System;
using System.Collections.Generic;

namespace c_dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languagesWithScore = new Dictionary<string, int>() {
                {"English", 4},
                {"Spanish", 0},
                {"C#", 4}
            };
            //adding javascript, 3 key/value pair
            languagesWithScore.Add("JavaScript", 3);
            //adding French, 5 key/value pair
            languagesWithScore["French"] = 5;
            //changing the value of "spanish"
            languagesWithScore["Spanish"] = 1;
            PrintDictionary(languagesWithScore);
            //grabbing the value of "French"
            int frenchScore = languagesWithScore["French"];

            //list that contains two dictionaries: languagesWithScore and languagesWithScore2
            //in JavaScript this would be akin to two objects within an array
            List<Dictionary<string, int>> langScoreList= new List<Dictionary<string, int>>();
            langScoreList.Add(languagesWithScore);

            Dictionary<string, int> languagesWithScore2 = new Dictionary<string, int> () {
                {"English", 5}
            };
            langScoreList.Add(languagesWithScore2);
            //iterating over the list that contains to dictionaries
            Console.WriteLine("Printing LangeScoreList");
            foreach(Dictionary<string,int> lang in langScoreList) {
                PrintDictionary(lang);
            }

            //using ContainsValue for practice
            if (languagesWithScore.ContainsValue(8)) {
                Console.WriteLine("Yay!");
            } else {
                Console.WriteLine("BOO!");
            }


        }
        static void PrintDictionary(Dictionary<string,int> dict) {
            foreach(KeyValuePair<string, int> kvp in dict) {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }
    }
}
