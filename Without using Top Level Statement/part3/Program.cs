using System;



namespace part3
{
    public class Program
    {
        static double DoDivision(double x , double y)
        {
            if (y == 0)
            {
                throw new System.DivideByZeroException();

            }
            return x / y ;
        }
        static void Main(string[] args)
        {
           double num1 = 5;
           double num2 = 0;

           try
           {
            Console.WriteLine($" 5 / 0 = {DoDivision(num1, num2)}");
           }

           catch (DivideByZeroException ex)
           {
            Console.WriteLine("You can't divide by zero");
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);// prints out default message
           }

           catch(Exception ex)
           {
            Console.WriteLine("An error");
            Console.WriteLine(ex.GetType().Name);
            Console.WriteLine(ex.Message);
           }

            finally
            {
                Console.WriteLine("Cleaning up");

            }

        }
    }
}