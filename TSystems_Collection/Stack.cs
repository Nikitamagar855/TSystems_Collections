using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TSystems_Collection_NonGeneric { 

    class Stack1
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(55);
            stack.Push(99);
            stack.Push(11);
            stack.Push(44);
            Console.WriteLine("===========stack===============");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("====after performing pop operation====");

            stack.Pop();
            stack.Pop();
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();





        }
    }
} 
