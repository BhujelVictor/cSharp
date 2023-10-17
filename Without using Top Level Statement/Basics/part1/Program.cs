using System;


namespace part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            // implicit type cast
            bool boolFromStr = bool.Parse("true");
            int intFromStr = int.Parse("100");
            double dblFromStr = double.Parse("1.456");

            Console.WriteLine(boolFromStr);
            Console.WriteLine(intFromStr);
            Console.WriteLine(dblFromStr);

            // get data type
            Console.WriteLine(boolFromStr.GetType());
            
            // formatting output
            Console.WriteLine("Currency : {0:c}", 19.99);
            Console.WriteLine("Pad with 0s : {0:d4}", 24);
            Console.WriteLine("3 Decimals : {0:f3}", 9.99999);
            Console.WriteLine("Commas : {0:n4}", 3200);

            //strings
            string rndString = "This is a random string";
            Console.WriteLine($"String Length : {rndString.Length}");
            Console.WriteLine($"String contains is? : {rndString.Contains("is")}");
            Console.WriteLine($"String index of 'is' : {rndString.IndexOf("is")}");
            Console.WriteLine($"Remove string : {rndString.Remove(5)}");
            Console.WriteLine($"Insert string : {rndString.Insert(23, " String was inserted.")}");
            Console.WriteLine($"Replace string : {rndString.Replace("random string", "String was replaced")}");

            Console.WriteLine($"Compare A to B : {String.Compare("A", "B",StringComparison.OrdinalIgnoreCase)}");
            // Ignoring case and comparing string
            // < 0 : string1 precedes string2
            // = 0 : string1 equals string2
            // > 0 : string2 precedes string1

            Console.WriteLine($"A = a : {String.Equals("A", "a", StringComparison.OrdinalIgnoreCase)}");
            Console.WriteLine($"Pad left : {rndString.PadLeft(30, '.')}");
            Console.WriteLine($"Pad right : {rndString.PadRight(30, '.')}");
            Console.WriteLine($"Trim : {rndString.Trim()}");
            Console.WriteLine($"Uppercase : {rndString.ToUpper()}");
            Console.WriteLine($"Lowercase : {rndString.ToLower()}");
            
            string newString = String.Format("{0} saw a {1} {2} in the {3}", "Harry", "dog", "pissing", "field.");
            Console.Write(newString + "\n");

            // using verbatim string literal '@'
            Console.WriteLine(@"Exactly what I typed ain't it \n");
            

        }
    }
}