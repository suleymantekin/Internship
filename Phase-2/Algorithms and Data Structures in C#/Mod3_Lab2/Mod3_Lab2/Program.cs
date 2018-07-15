using System;
using System.Collections;

namespace Mod3_Lab2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Hashtable openWith = new Hashtable();

            // Add some elements to the hash table. There are no 
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "winword.exe");
            }
            catch
            {
                Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // The default Item property can be used to change the value associated with a key.
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // If a key does not exist, setting the default Item property for that key adds a new key/value pair.
            openWith["doc"] = "winword.exe";

            // ContainsKey can be used to test keys before inserting 
            // them.
            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
            }

            // We are using a DictionaryEntry type in the foreach loop and not a Hashtable type 
            // because the whole class is a hashtable but the items in the hashtable are known as dictionary entries.

            Console.WriteLine();
            foreach(DictionaryEntry de in openWith )
            {
                Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
            }
        }
    }
}
