namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList

            //Initialize rhyme to lullaby, chose the itsy bitsy spider
            string[] rhyme = { "The", "itsy", "bitsy", "spider", "climbed", "up", "the", "waterspout" };

            //Initialize linkedlist
            LinkedList<string> list = new LinkedList<string>(rhyme);

            Console.WriteLine("Linked list using foreach loop: "); 
            //Print out using enumerator
            foreach (string s in list)
            {
                Console.Write(s + " ");  
            }

            //Walk the linked list...

            Console.WriteLine("\n\nWalking the linked list:"); 

            LinkedListNode<string> node = list.First;
            LinkedListNode<string> savedNode = null; //Empty node to use later... 
            int nodeCount = 0; 
            while (node != null)
            {
                nodeCount++;
                Console.Write(node.Value + " "); 
                node = node.Next; //Move to the next node..
            }
            //Remove a word from the middle of the list

            Console.WriteLine("\n\nRemoving the middle word: "); 
            //Start by getting count of number of nodes

            //Not worrying about if linked list is even versus odd length
            //Then divide that count by two to find where the middle node(s) might be 
            int length = nodeCount / 2;
            int count = 1; //Count to keep track of node count

            node = list.First; //Reset header node, currently at null...
            while (count <= length && node!= null)
            {
                count++;
                node = node.Next;
            }
            savedNode = node; //Save the middle node (to be used again when adding back into the linked list). 
            list.Remove(node); //Remove the middle node
            node = list.First; //Reset the first node again, otherwise it will still be pointing to the middle word

            //Rewrite sentence without the middle word
            while (node != null)
            {
                Console.Write(node.Value + " "); 
                node = node.Next;
            }

            Console.WriteLine("\n");

            //Print again with word restored back to the list
            node = list.First; //Reset once again...

            Console.WriteLine("Adding the middle word back in...");
            count = 1; //Reset count
            while (count < length)
            {
                node = node.Next; //Traverse through the nodes...
                count++;
            }
            list.AddAfter(node, savedNode.Value); //Add in the middle word at the point it was removed  
            
            node = list.First; //Reset...sigh...again...

           //Print out the rhyme again with middle work back in
            while (node != null)
            
            {
                Console.Write(node.Value + " ");
                node = node.Next; 
            }
            Console.WriteLine("\n");
            #endregion
        }
    }
}
