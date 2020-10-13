using System;
using System.Linq;
using System.Collections.Generic;

class MainClass {
  public static int Main (string[] args) {
            Console.WriteLine("Hello World!");
            string fileName = "missing_number.txt";
            if (args.Length == 0)
            {
                Console.WriteLine("no argument using default");
            } else
            {
                Console.WriteLine("Your Argument is");
                Console.WriteLine(args[0]);
                fileName = args[0];
            }

            string[] lines = System.IO.File.ReadAllLines(fileName);
            Console.WriteLine(lines.Length);
            Console.WriteLine($"Your file has {lines.Length} lines!");

            int[] numbers = lines.Select(int.Parse).ToArray();
            LinkedList<int> numlist = new LinkedList<int>(numbers);

            // Console.WriteLine($"Head of list is {numlist.last.value}");
             Console.WriteLine(numbers[0]);
             Console.WriteLine(numlist.Count); //we got something!
             Console.WriteLine(numlist.First.Value); //we got something!
             Console.WriteLine(numlist.First.Next?.Value);
             Console.WriteLine(numlist.First.Next?.Next?.Value);
             //we do need to check if the next or last node exits right ? :)
             Console.WriteLine(numlist.First.Previous?.Value);

             bool isPalindrome = true;

             LinkedListNode<int> beg = numlist.First;
             LinkedListNode<int> end = numlist.Last;

             while (beg != null && end != null) {
               if (beg.Value != end.Value) {
                 isPalindrome = false;
                 break;
               }
               beg = beg.Next;
               end = end.Previous;
             }
             //it is much easier with a doubly linked list
             Console.WriteLine($"List is palindrome: {isPalindrome}");






            return 0;
  }
}