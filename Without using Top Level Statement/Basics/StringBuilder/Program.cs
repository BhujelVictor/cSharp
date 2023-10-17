using System;
using System.Globalization;
using System.Text;



namespace part3
{
    public class Program
    {

       


        static void Main(string[] args)
        {
            StringBuilder sb = new("Random Text.");
            StringBuilder sb1 = new StringBuilder("This is just another text.", 256);
            Console.WriteLine($"Capacity : {sb1.Capacity}");
            Console.WriteLine($"Length : {sb1.Length}");
            sb1.AppendLine(" More random text.");// added string to the end
            CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
            string bestCust = "Bob Smith";
            sb1.AppendFormat(enUS, $"Best Customer : {bestCust}");// formatted according to en-US
            Console.WriteLine(sb1.ToString());
            sb1.Replace("another", "different");
            Console.WriteLine(sb1.ToString());
            sb1.Clear();
            sb1.Append("Random Text.");
            Console.WriteLine(sb1.Equals(sb));
            sb1.Insert(11, " that's it");
            Console.WriteLine(sb1.ToString());
            sb1.Remove(11, 7);
            Console.WriteLine(sb1.ToString());

        }
    }
}