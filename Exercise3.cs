using System;

namespace GCExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeatProgram = true;
            while (repeatProgram)
            {
                Console.WriteLine("Enter number:");
                double number = Convert.ToDouble(Console.ReadLine());

                double addedNumber = number + 0.5;

                Console.WriteLine(addedNumber);
                

                Console.WriteLine("Do you want to try another one?  y/n");
                string repeat = Console.ReadLine();

                while (repeat != "N" && repeat!= "n" && repeat!= "Y" && repeat!= "y")
                {
                    Console.WriteLine("Invalid Entry. Enter N or Y please");
                     repeat = Console.ReadLine(); 

                }

                if (repeat == "N" || repeat== "n")
                {
                    Console.WriteLine("Good Bye");
                    Console.WriteLine(""); // for space
                    Console.WriteLine(" Press any key to exit");
                    Console.ReadLine();


                    repeatProgram = false;
                }

                
            }

        }
    }
}
/*
 * EXERCISE 3DescriptionPrompt the user to enter a number. 
 * After the user enters a number, add .5 to the number andoutput it back to the console.
 * Example>>Enter a number: <<17.3>>17.8
 */
