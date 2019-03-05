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
            // PrintDictionary(languagesWithScore);
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
                // PrintDictionary(lang);
            }

            //using ContainsValue for practice
            if (languagesWithScore.ContainsValue(8)) {
                // Console.WriteLine("Yay!");
            } else {
                // Console.WriteLine("BOO!");
            }

            //A dictionary of dictionaries
            Dictionary<string, Dictionary<string, int >> people =
                new Dictionary<string, Dictionary<string, int>>() {
                    {
                        "Hunter",
                        new Dictionary<string, int>() { {"French", 5} }
                    }, {
                        "Jordan",
                        new Dictionary<string, int>() { {"English", 4}, {"Spanish", 4} }
                    }
                };

            //Practice: Stock Purchase Dictionaries
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            stocks.Add("TSLA", "Tesla");
            stocks.Add("AAPL", "Apple, Inc.");


            // Next, create a list to hold stock purchases by an investor. The list will contain dictionaries.
            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add (new Dictionary<string, double>(){ {"GM", 230.21} });
            purchases.Add (new Dictionary<string, double>(){ {"GM", 580.98} });
            purchases.Add (new Dictionary<string, double>(){ {"GM", 406.34} });
            purchases.Add (new Dictionary<string, double>(){ {"CAT", 500.02} });
            purchases.Add (new Dictionary<string, double>(){ {"CAT", 540.33} });
            purchases.Add (new Dictionary<string, double>(){ {"TSLA", 400.53} });
            purchases.Add (new Dictionary<string, double>(){ {"TSLA", 550.12} });
            purchases.Add (new Dictionary<string, double>(){ {"AAPL", 250.08} });
            purchases.Add (new Dictionary<string, double>(){ {"AAPL", 156.22} });


            //  foreach(Dictionary<string,double> dict in purchases) {
            //     PrintPurchaseDictionary(dict);
            // }

            Dictionary<string, double> stockReport = new Dictionary<string, double>();
                foreach (Dictionary<string, double> purchase in purchases) {

                foreach (KeyValuePair<string, double> stock in purchase)
                {
                    // Does the full company name key already exist in the `stockReport`?
                    // If it does, update the total valuation
                    if (stockReport.ContainsKey(stocks[stock.Key])) {
                     stockReport[stocks[stock.Key]] += stock.Value;
                     /*
                        If not, add the new key and set its value.
                        You have the value of "GE", so how can you look
                        the value of "GE" in the `stocks` dictionary
                        to get the value of "General Electric"?
                    */
                    } else {
                        stockReport.Add(stocks[stock.Key], stock.Value);
                    }
                }
                    //Console Write each stock within the newly created report
                    //  foreach (KeyValuePair<string, double> item in stockReport) {
                    // Console.WriteLine($"The position in {item.Key} is worth {item.Value}");
                    // }
            }

            //PRACTICE: ITERATING OVER PLANETS
            //list of all planets
            List<string> planetList = new List<string>()
                {
                    "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn","Uranus","Neptune"
                };

            // Create another list containing dictionaries. Each dictionary will hold the name of a spacecraft that we have launched, and the name of the planet that it has visited. If it visited more than one planet, just pick one.
            List<Dictionary<string,string>> probes = new List<Dictionary<string,string>>();
                probes.Add(new Dictionary<string,string>(){{"Mercury", "Mariner"}});
                probes.Add(new Dictionary<string,string>(){{"Venus", "Mariner 2"}});
                probes.Add(new Dictionary<string,string>(){{"Earth","International Space Station"}});
                probes.Add(new Dictionary<string, string>(){{"Mars", "Curiosity"}});
                probes.Add(new Dictionary<string, string>(){{"Mars", "Another SpaceCraft"}});
                probes.Add(new Dictionary<string, string>(){{"Jupiter","Juno"}});
                probes.Add(new Dictionary<string,string>(){{"Saturn","Cassini"}});
                probes.Add(new Dictionary<string, string>(){{"Uranus","Voyager 2"}});
                probes.Add(new Dictionary<string, string>(){{"Neptune","Voyager 1"}});
                Console.WriteLine("PROBE DICTIONARIES LIST");
                Console.WriteLine("----------------");
                foreach(Dictionary<string,string> probe in probes) {
                    PrintPlanetDictionary(probe);
                }

                // Iterate over planetList, and inside that loop, iterate over the list of dictionaries. Write to the console, for each planet, which satellites have visited which planet.
                Console.WriteLine("----------------");
                Console.WriteLine("Matching Probes");
                Console.WriteLine("----------------");
                foreach (string planet in planetList) // iterate planets
                {
                    List<string> matchingProbes = new List<string>();

                    foreach(Dictionary<string, string> probe in probes) // iterate probes
                    {
                        /*
                            Does the current Dictionary contain the key of
                            the current planet? Investigate the ContainsKey()
                            method on a Dictionary.
                            If so, add the current spacecraft to `matchingProbes`.
                        */
                        if (probe.ContainsKey(planet)) {
                            matchingProbes.Add(probe[planet]);
                            // Console.WriteLine("it matches!");
                        }
                    }
                    foreach(string matchingProbe in matchingProbes) {
                        string SpaceCraft = String.Join(",", matchingProbes);
                            Console.WriteLine($"{planet}: {SpaceCraft}");
                        }

                    /*
                        Use String.Join(",", matchingProbes) as part of the
                        solution to get the output below. It's the C# way of
                        writing `array.join(",")` in JavaScript.
                    */
                    // Console.WriteLine($"{}: {}");
                }

        }
        static void PrintDictionary(Dictionary<string,int> dict) {
            foreach(KeyValuePair<string, int> kvp in dict) {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }
        static void PrintPurchaseDictionary(Dictionary<string,double> dict) {
            foreach(KeyValuePair<string, double> kvp in dict) {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }

        static void PrintPlanetDictionary(Dictionary<string,string> dict) {
            foreach(KeyValuePair<string, string> kvp in dict) {
                Console.WriteLine($"key: {kvp.Key}, value: {kvp.Value}");
            }
        }

    }
}
