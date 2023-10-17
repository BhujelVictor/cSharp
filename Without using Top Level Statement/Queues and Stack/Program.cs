using System;
using System.Collections;

namespace qwe
{
    class Queues
    {


        static void Main(string[] args)
        {
            //*****Queue
            // Last in First out in queue operation
            Queue queue = new();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);

            Console.WriteLine($"1 in Queue : {queue.Contains(1)}");

            // removes the first item from the queue
            Console.WriteLine($"Remove : {queue.Dequeue()}");


            // peeks at the first item of the collection
            Console.WriteLine($"Peek 1 : {queue.Peek()}");

            object[] numArray = queue.ToArray();

            Console.WriteLine(String.Join(",", numArray));
            foreach (object o in queue)
            {
                Console.WriteLine($"Queue : {o}");
            }

            queue.Clear();
            Console.WriteLine($"Count : {queue.Count}");


            // *****Stack
            // First in First Out operation in Stack


            Stack stack = new();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);


            // Peeks at the last item of the collection
            Console.WriteLine($"Peek 1 : {stack.Peek()}");

            Console.WriteLine($"Pop 1 : {stack.Pop()}");

            Console.WriteLine($"Conatins 4: {stack.Contains(4)}");
            Console.WriteLine($"Conatins 1: {stack.Contains(1)}");

            stack.ToArray();
            
            // object[] numArray2 = stack.ToArray();

            // Console.WriteLine(String.Join(",", numArray2));

            foreach(object o in stack)
            {
                Console.WriteLine($"Stack : {o}");
            }





        }
    }
}