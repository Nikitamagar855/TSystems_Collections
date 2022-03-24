using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace TSystems_Collection_NonGeneric
{
    class Queue1
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(55);
            q.Enqueue(44);
            q.Enqueue(88);
            q.Enqueue(12);
            q.Enqueue(77);
            Console.WriteLine("===========queue=====");
            foreach (object item in q)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("==============AFTER PERFORMING dqueue OPERATION======");
            q.Dequeue();
            q.Dequeue();
            foreach (object item in q)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();


        }
        

    }
}
