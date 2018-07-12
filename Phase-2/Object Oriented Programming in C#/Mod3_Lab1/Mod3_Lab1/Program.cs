using System;
using System.Globalization;
using System.IO;

namespace Mod3_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            
            StreamReader streamReaderObject = null;

            try
            {
                streamReaderObject = new StreamReader("file1.txt");

                // Reads all characters from the current position to the end of the stream
                // Stores in String variable "contents"
                String contents = streamReaderObject.ReadToEnd();

                streamReaderObject.Close();

                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
                Console.WriteLine("The file has text: " + contents);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file cannot be found.");
            }
            finally
            {
                if (streamReaderObject != null)
                {
                    streamReaderObject.Dispose();
                    Console.WriteLine("\n\nCleaned the resources.");
                }
            }
        }
    }
}
