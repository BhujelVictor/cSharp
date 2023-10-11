
// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue, secondValue);


// Console.WriteLine(largerValue);

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if(message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// // roll1 = 6;
// // roll2 = 6;
// // roll3 = 6;

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//         total += 2;
//     }
// }



// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }

// else
// {
//     Console.WriteLine("Sorry, you lost.");
// }

// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

// string[] fraudulentOrderIDs = new string[3];

// fraudulentOrderIDs[0] = "A123";
// fraudulentOrderIDs[1] = "B456";
// fraudulentOrderIDs[2] = "C789";

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "ASDf";
// Console.WriteLine($"Reassigned first strinng: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// string[] names = {"Rowena", "Robin", "Hayabusa"};
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = {20,45,70,17,25};
// int sum = 0;
// int bin = 0;
// foreach(int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"The sum of items is {sum}");

// string[] fraud = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
// foreach(string name in fraud)
// {
//     if(name.StartsWith('B'))
//     {
//         Console.WriteLine(name);
//     }
// }

// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");
//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }


using System;
namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Console
        .
        WriteLine
        (
        "Hello Test 1"
        )
        ;

        string firstWord = "Hello"; string lastWord = "Test 2";
        Console.WriteLine(firstWord + " " + lastWord);

        string str = "The quick brown fox jumps over the lazy dog.";

        char[] charMessage = str.ToCharArray();

        Array.Reverse(charMessage);
        int x = 0;

        foreach (char i in charMessage) { if (i == 'o') { x++; } }

        string new_message = new string(charMessage);

        Console.WriteLine(new_message);
        Console.WriteLine($"'o' appears {x} times.");
    }
}