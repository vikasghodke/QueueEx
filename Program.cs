using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackPractice
{
    internal class Maintest
    {
        static void Main(string[] args)
        {
            Queue<int> q1 = new Queue<int>(8);
            q1.Enqueue(1);
            q1.Enqueue(3);
            q1.Enqueue(5);
            q1.Enqueue(6);
            q1.Enqueue(7);
            q1.Dequeue();
            q1.Dequeue();

            while(q1.Count>0)
            {
                Console.WriteLine(q1.Dequeue());
            }
           

        }
    }
}