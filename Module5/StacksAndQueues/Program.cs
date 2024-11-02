namespace StacksAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Stack

            //Define array
            int[] array = new int[] { 1,2,3,4,5};
            
            //Intiialize stack
            Stack<int> stack = new Stack<int>(array);

            //Was not sure if I did this part correctly, print out stack
            Console.WriteLine("Items in the stack are: ");
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine(" "); //Print a blank space
            Console.WriteLine("Item at the top of the stack is");

            //Print item on the top of the stack
            Console.WriteLine(stack.Peek());
            Console.WriteLine(" ");
            Console.WriteLine("Popping items...");

            //Pop items from the stack and then print them out
            for(int i = 0; i < array.Length; i++)
            {
                int num = stack.Pop(); //Save the value popped
                Console.WriteLine(num);
            }

            #endregion

            #region Queue

            //Define a queue
            Queue<int> queue = new Queue<int>();
            for (int i = 1; i < 6; i++)
            {
                queue.Enqueue(i);
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("Items in queue: "); 
            //Print the queue
            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" ");
            Console.WriteLine("Item at the top of the queue is: ");
            
            //Peek at the first item in queue
            Console.WriteLine(queue.Peek()); 

            Console.WriteLine(" ");

            Console.WriteLine("Deque-ing of the queue"); 
            //Dequeue the queue and print out the values 
            for(int i = 0; i < 5; i++)
            {
                int numq = queue.Dequeue(); //save the item so I can print
                Console.WriteLine(numq);
            }   
            Console.WriteLine(" ");
            #endregion
        }
    }
}
