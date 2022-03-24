using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystems_Collection_nongeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(5);
            list.Add("NIKITA");
            list.Add(12.5);

            foreach(object item in list)//display by using  foreach 
            {
                Console.WriteLine(item);
            }
            list.Insert(2, 99);
            Console.WriteLine("=======after insertion================");
            for (int i = 0; i < list.Count; i++)//display by using forloop
            {
                Console.WriteLine(list[i]);
            }
            list.Remove("NIKITA");
            list.RemoveAt(1);
            Console.WriteLine("==========AFTER REMOVING OBJECT=======");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("Total Element Count"+ "  "+list.Count);//for displaying total element of  list
            Console.WriteLine(list.Capacity);//to know the total memory alocation

            
            Console.ReadLine();

        }
    }
}
