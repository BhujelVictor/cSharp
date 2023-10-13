using System;


namespace part2
{
    public class Program
    {   

        // static void PrintArray(int[] intArray, string message)
        // {
        //     foreach(int i in intArray)
        //     {
        //         Console.WriteLine($"{message} : {i}");
        //     }
        // }

        static void Main(string[] args)
        {
            // int[] favNums = new int[3];
            // favNums[0] = 23;
            // Console.WriteLine($"favNum 0 : {favNums[0]}");
            // string[] customers = {"Bob", "Sally", "Sue"};
            // var employees = new[] {"Mike", "Paul", "Harry"};
            // object[] randomArray = {"Harry",1,2,23,8.99};
            // Console.WriteLine($"randomArray : {randomArray[0].GetType()}");
            // Console.WriteLine($"randomArray size : {randomArray.Length}");

            // for (int i = 0; i < randomArray.Length; i++)
            // {
            //     Console.WriteLine($"Array : {i} Value : {randomArray[i]} ");

            // }

            // // 2d array

            // string[,] custNames = new string[2,2] {{"Harry","Selena"},{"Sam", "Derek"}};

            // Console.WriteLine($"Value : {custNames.GetValue(0, 1)}");

            // for (int i = 0; i < custNames.GetLength(0); i++)
            // {
            //     for (int j = 0; j < custNames.GetLength(0); j++)
            //     {
            //         Console.WriteLine($"{custNames[i,j]}");

            //     }
            //     Console.WriteLine();
            // }

            // int[] randNums = {1,3,4,8,9};
            // PrintArray(randNums, "test");

            // Array.Sort(randNums);
            // Array.Reverse(randNums);
            // Console.WriteLine($"Index of 1 : {Array.IndexOf(randNums, 1)}");

            // int[] scrArray = {1,2,3};
            // int[] destArray = new int[2];
            // int startInd = 0;
            // int length = 2;
            // Array.Copy(scrArray, startInd, destArray, 0 , length);
            // PrintArray(destArray, "copied");
            // Array anotherArray = Array.CreateInstance(typeof(int), 10);
            // scrArray.CopyTo(anotherArray,5);

            // foreach(int x in anotherArray)
            // {
            //     Console.WriteLine($"anotherArray : {x}");
            // }

            // int[] numArray = {1,2,6,7,8,9};
            // Console.WriteLine($"> 5 : {Array.Find(numArray, )}");

            // Do While loop
            Random rnd = new Random();
            int secretNumber = rnd.Next(1,11);
            int numberGuessed = 0;
            Console.WriteLine("Random Num : ");

            do{
                Console.WriteLine("Enter a number between 1 & 10 : ");
                numberGuessed = Convert.ToInt16(Console.ReadLine());     
            } while (secretNumber != numberGuessed);

            Console.WriteLine($"You guessed it, it was {secretNumber}");



        }
    }
}