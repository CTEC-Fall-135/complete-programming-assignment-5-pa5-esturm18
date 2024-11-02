namespace DictionaryUse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            //Initialize dictionary
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict[1] = "one";
            dict[2] = "two";
            dict[3] = "three";
            dict.Add(99, "ninety-nine");


            Console.WriteLine(" ");
            Console.WriteLine("Dictionary keys/values using keyvaluepair: ");
            //Print out the values
            foreach (KeyValuePair<int, string> kvp in dict)
            { //Iterate through the dictionary!
                Console.WriteLine($"Key = {kvp.Key} and value = {kvp.Value}");
            }

            Console.WriteLine(" ");

            //Change ninety-nine value to "99"
            dict[99] = "99"; 
            Console.WriteLine(" ");
            Console.WriteLine("Printing value of 99: ");
            Console.WriteLine(dict[99]);
            Console.WriteLine(" ");

            //Remove the 2 item
            dict.Remove(2);

            //Print the updated dictinoary
            Console.WriteLine("Updated dictionary: ");

            foreach (KeyValuePair<int, string> kvp in dict)
            { //Iterate through the dictionary!
                Console.WriteLine($"Key = {kvp.Key} and value = {kvp.Value}");
            }

            Console.WriteLine(" ");
            #endregion

        }
    }
}
