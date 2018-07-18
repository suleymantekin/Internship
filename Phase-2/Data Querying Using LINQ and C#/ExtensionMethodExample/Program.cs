using System;

namespace ExtensionMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // var pi = 3.14;
            // //var pif = string.Format("${0}", pi);
            // var pif = pi.FormatWith("${0}");
            // System.Console.WriteLine(pif);

            var name = "Timothy";
            var nameFormatted = name.FormatWith("Hello, {0}");
            System.Console.WriteLine(nameFormatted);

        }
    }

    static class FormatExtension
    {
        public static string FormatWith(this object caller, string template)
        {
            if (string.IsNullOrEmpty(template) || !template.Contains("{0}"))
            {
                throw new ArgumentException("Please provide a valid format template.");
            }

            var result = string.Format(template, caller);
            return result;
        }
    }
}
