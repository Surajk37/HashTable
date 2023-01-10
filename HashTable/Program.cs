﻿namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\tWelcome to Hashtable and BinarySearchTree Programs\n");
            Console.WriteLine("Enter the option given below");      
            Console.WriteLine("1:Find frequency of words");
            int option = Convert.ToInt32(Console.ReadLine());

            static void CountNumbOfOccurence(string paragraph)          //Method to get final frequency
            {
                MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);

                string[] words = paragraph.Split(' ');

                foreach (string word in words)
                {
                    if (hashTabe.Exists(word.ToLower()))
                        hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                    else
                        hashTabe.Add(word.ToLower(), 1);
                }
                Console.WriteLine("Displaying after add operation");
                hashTabe.Display();
            }
            switch (option)
            {
                case 1:
                    CountNumbOfOccurence("To be or not to be");
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;

            }
            Console.ReadLine();
        }
    }
}