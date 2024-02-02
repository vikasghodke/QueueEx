using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueDS
{
    public class Queue
    {
        private int[] arr;
        private int capacity;
        private int front;
        private int rear;
        private int size;

        public Queue(int capacity)
        {
            capacity = capacity;
            arr = new int[capacity];
            front = 0;
            rear = -1;
            size = 0;
        }
        public void Enqueue(int item)
        {
            if (size == capacity)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                rear = (rear + 1) % capacity;
                arr[rear] = item;
                size++;
            }
        }
        public int Dequeu(int item)
        {
            if(size==0)
            {
                Console.WriteLine("Queue is empty");
                return-1;
            }
            else
            {
                int dequeitem = arr[front];
                front = (front + 1) % capacity;
                size--;
                return dequeitem;
            }
        }
       


    }
}
