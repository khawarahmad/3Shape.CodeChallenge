using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _3Shape.CodeChallenge
{
    /// <summary>
    /// A class to contain the shared methods to implementthe text related operations
    /// </summary>
    public class TextOps
    {
        /// <summary>
        /// Character array containing all the characters used to split the file text
        /// </summary>
        private static char[] stringSplitters = new char[] { ' ', '.', ',', '\r', '\n' };

        /// <summary>
        /// A Method to split text into individual word list
        /// </summary>
        /// <param name="fileText">Text from the file</param>
        /// <returns></returns>
        public static List<string> TextSplitter(string fileText)
        {
            return fileText.Split(stringSplitters, StringSplitOptions.RemoveEmptyEntries).ToList(); ;            
        }

        /// <summary>
        /// A method to count the occurences of all unique words in the text
        /// </summary>
        /// <param name="allWords">List of all words</param>
        /// <returns></returns>
        public static Dictionary<string, int> CountOccurences(List<string> allWords)
        {
            Dictionary<string, int> uniqueWordList = new Dictionary<string, int>();
            foreach (string word in allWords)
            {
                if (!uniqueWordList.ContainsKey(word.ToLower()))
                {
                    uniqueWordList.Add(word.ToLower(), allWords.FindAll(w => w.Equals(word, StringComparison.InvariantCultureIgnoreCase)).Count);                
                }
            }
            return uniqueWordList;
        }

        /// <summary>
        /// A method to display the unique words and their count
        /// </summary>
        /// <param name="uniqueWordList"></param>
        public static void PrintWordsandCount(Dictionary<string, int> uniqueWordList)
        {
            int total = 0;
            foreach (string key in uniqueWordList.Keys)
            {
                total += uniqueWordList[key];
                Console.WriteLine($"{key}: {uniqueWordList[key]}");
            }
            Console.WriteLine(total);
        }
    }
}
