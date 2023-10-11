namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("What is your name? ");
            // string name = Console.ReadLine();
            // Console.WriteLine($"Hello {name}");
            // double heightInMeters = 1.88;
            // Console.WriteLine($"The variable {nameof(heightInMeters)} has value {heightInMeters}");
            // Console.WriteLine("Biggest Double value: {0}", Double.MaxValue);
            // Console.WriteLine("BIggest int value: {0}", int.MaxValue);
            // Console.WriteLine("BIggest decimal value: {0}", Decimal.MaxValue);
           
            // int decimalNotation = 2_000_000;
            // int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            // int hexadecimalNotation = 0x_001E_8480;
            // Console.WriteLine($"{decimalNotation == binaryNotation}");
            // Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
            // Console.WriteLine("a" == "a");
            // Console.WriteLine("a" == "A");
            // Console.WriteLine(1 == 2);

            // string myValue = "a";
            // Console.WriteLine(myValue == "a");
            
            // string value1 = " a";
            // string value2 = "A ";
            // Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
            // Console.WriteLine("a" != "a");
            // Console.WriteLine("a" != "A");
            // Console.WriteLine(1 != 2);

            // string myValue = "a";
            // Console.WriteLine(myValue != "a");

            // Console.WriteLine(1 > 2);
            // Console.WriteLine(1 < 2);
            // Console.WriteLine(1 >=1);
            // Console.WriteLine(1 <=1);
            
            // string pangram = "The quick fox jumps over the lazy dog.";
            // Console.WriteLine(pangram.Contains("fox"));
            // Console.WriteLine(pangram.Contains("cow"));

            // Console.WriteLine(pangram.Contains("fox") == false);
            // Console.WriteLine(!pangram.Contains("fox"));

            // Console.WriteLine(!pangram.Contains("fox"));
            // Console.WriteLine(!pangram.Contains("cow"));

            //int saleAmount = 1001;
            //int discount = saleAmount > 1000? 100 : 50;
            //Console.WriteLine($"Discount: {discount}");
            
            //Console.WriteLine($"Discount: {(saleAmount > 1000? 100 : 50)}");

            // Random coin = new Random();
            // int flip = coin.Next(0, 2); // Next returns a random value within the range
            // Console.WriteLine((flip == 0)? "heads" : "tails");

            string permission = "Admin";
            int level = 55;
            if(permission.Contains("Admin"))
            {
                if(level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin User.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }   
            }
            else if(permission.Contains("Manager"))
            {
                if(level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                  Console.WriteLine("You do not have sufficient privilge.");  
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privilge.");
            }
            
        }
    }


}
