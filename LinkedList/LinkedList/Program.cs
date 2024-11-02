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

            //Print out using enumerator
            string sentence = ""; 
            foreach (string s in list)
            {
                sentence += s + " "; 
                //I concatenate the individual words into a single sentence
                //Makes it so it prints on one line in stdout.
            }
            Console.WriteLine($"{sentence}");

            //Walk the linked list...

            Console.WriteLine(" ");
            Console.WriteLine("Walking the linked list"); 

            LinkedListNode<string> node = list.First;
            LinkedListNode<string> savedNode = null; //Empty node to use later... 
            string sentence1 = "";
            int nodeCount = 0; 
            while (node != null)
            {
                nodeCount++;
                Console.Write(node.Value + " "); 
                node = node.Next; //Move to the next node..
            }
            //Remove a word from the middle of the list

            Console.WriteLine(" ");
            Console.Write("Removing..."); 
            Console.WriteLine(" "); 
            //Start by getting count of number of nodes

            //Not worrying about if linked list is even versus odd length
            //Then divide that count by two to find where the middle node(s) might be 
            int length = nodeCount / 2;
            int count = 1;

            node = list.First; //Reset header node, currently at null...
            while (count <= length && node!= null)
            {
                count++;
                node = node.Next;
            }
            savedNode = node; 
            list.Remove(node); //Remove the middle node
            node = list.First; //Reset the first node again, otherwise it will still be pointing to the middle word

            string sentence3 = "";

            //Rewrite sentence without the middle word

            while (node != null)
            {
                Console.Write(node.Value + " "); 
                node = node.Next;
            }

            Console.WriteLine(" ");

            //Print again with word restored back to the list
            node = list.First; //Reset once again...


            #endregion
        }
    }
}
