using TrafficManager.Models;

namespace TrafficManager.DataStructures
{
    class VehicleQueue
    {
        private Vehicle[] queue;
        private int front, rear, capacity;

        public VehicleQueue(int capacity)
        {
            this.capacity = capacity;
            queue = new Vehicle[capacity];
            front = rear = -1;
        }

        private bool IsFull()
        {
            return rear == capacity - 1;
        }

        private bool IsEmpty()
        {
            return front == -1 || front > rear;
        }

        public void Enqueue(Vehicle vehicle)
        {
            if (IsFull())
            {
                System.Console.WriteLine("Queue Overflow");
                return;
            }

            if (front == -1)
                front = 0;

            queue[++rear] = vehicle;
        }

        public Vehicle Dequeue()
        {
            if (IsEmpty())
            {
                System.Console.WriteLine("Queue Underflow");
                return null;
            }

            return queue[front++];
        }

        public void Display()
        {
            if (IsEmpty())
            {
                System.Console.WriteLine("Queue is empty");
                return;
            }

            for (int i = front; i <= rear; i++)
            {
                System.Console.WriteLine(queue[i].ToString());
            }
        }
    }
}
