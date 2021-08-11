using System;
using System.Collections.Generic;


namespace IterationsLesson
{
    class Program
    {
        static void Main()
        {
            //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jesse", "Erik", "Daniel", "Adam" };
            //for (int j = 0; j < names.Length; j++)
            //{
            //    if (names[j] == "Jesse")
            //    {
            //        Console.WriteLine(names[j]);
            //    }
            //}

            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach(int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();


            //List<string> names = new List<string>() { "Jesse", "Erik", "Daniel", "Adam" };

            //foreach (string name in names)
                //Making the item name singular and the list name plural is good for readability.
            //{
                //if (name == "Jesse")
                //{
                //    Console.WriteLine(name);
                //}
                //    Console.WriteLine(name);
                //}
                //Console.ReadLine();

                List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
                List<int> passingScores = new List<int>();
                // Here, we are going to loop through 'testScores' and for each one that
                // passes, we're going to add it to 'passingScores.'

                foreach (int score in testScores)
                {
                    if (score > 85)
                    {
                        passingScores.Add(score);
                    }
                }

                Console.WriteLine(passingScores.Count);
                // A List has a property called 'Count' which tells you how many 
                // elements are in the list; Whereas an Array has '.Length' which
                // essentially does the same thing.
                Console.ReadLine();
        }
    }
}
