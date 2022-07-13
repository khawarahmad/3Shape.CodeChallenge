using System;

namespace _3Shape.CodeChallenge
{
    /// <summary>
    /// Main class
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the full file path and press enter:");
                string filePath = Console.ReadLine();
                TextOps.PrintWordsandCount(
                    TextOps.CountOccurences(
                        TextOps.TextSplitter(
                            new FileReader().ReadText(filePath)
                            )
                        )
                    );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ ex.Message}{Environment.NewLine}{ex.StackTrace}");
            }
        }
    }
}
