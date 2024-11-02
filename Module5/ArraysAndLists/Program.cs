namespace ArraysAndLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simply Array
            int[] array = new int[5]; 

            int count = 11;
            
            //For loop that sets the values of an array from 11 to 15.
            for (int i = 0; i < 5; i++)
            {
                array[i] = count;
                count++; 
            }

            Console.WriteLine("Printing out a simple array");

            //For each loop that prints out each element inside the array 'array'
         
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(""); //Create a blank space yes....!
            //End of simple array
            #endregion
                    
            #region List<T>
            
            List<int> list = new List<int>();

            int listCount = 21; 
            for (int i = 0; i < 5; i++)
            {
                list.Add(listCount);
                listCount++;
            }

            //Print out the values in the new list
            Console.WriteLine("Printing out List<T>"); 
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(" "); //Add a blank space
            //Need 31-35
            int newCount = 31;
            for (int i = 0; i < 5; i++)
            {
                list.Remove(listCount); //remove old item
                list.Add(newCount); //Put in new item
                newCount++; //increment newCount
                listCount--; //decrement old count
            }
            list.Remove(listCount); 

            
            //Print out the new values in the new list
            Console.WriteLine("Printing out List<T> with new values"); 
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
           //End of list code 
            #endregion
        }
    }
}
