using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace _3Shape.CodeChallenge
{
    /// <summary>
    /// A class to implement any and all methods related to reading files
    /// </summary>
    public class FileReader
    {
        /// <summary>
        /// A method to read text from teh file at a given path
        /// </summary>
        /// <param name="filePath">Path of the file to read text from</param>
        /// <returns></returns>
        public string ReadText(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
