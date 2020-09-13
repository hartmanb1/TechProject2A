/* 
 * Author: Brett Hartman
 * Date: 9/13/20
 * Comments: This C# Console application code is for Tech Assignment # 2a. 
 *           It demonstrates the use of iterative statements
*/

using System;

namespace TechProject2A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Obtain input from user
            Console.Write("Enter an Integer between 1 and 20 to execute an iterative statement: ");

            // Use Try-Catch block to validate input
            try
            {
                // Receive input from user
                string input = Console.ReadLine();

                // Define variable for input value
                int input_value = int.Parse(input);

                // If, else if, else if statement to determine which iterative statement to run

                // If the Input Value is between 1 and 5, execute a For Loop
                if ((input_value > 0) && (input_value <= 5))
                {
                    // Write lines that convey to the user what is happening
                    Console.WriteLine("Executing a For Loop!");
                    Console.WriteLine("The For Loop will iterate " + input_value.ToString() + " times.");

                    // Begin For Loop
                    for (int i = 0; i < input_value; i++)
                    {
                        // Tell user the value of each iteration
                        Console.WriteLine("The value of the variable i in this iteration is: " + i.ToString());
                    }  // End For Loop
                    // Ask user to press key to exit program
                    Console.WriteLine("Press any key to exit the program.");
                    // Take input from user
                    Console.ReadKey(true);
                } // End If Statment

                // If the Input Value is between 5 and 10, execute a While Loop
                else if ((input_value > 5) && (input_value <= 10))
                {
                    //Write lines that convey to the user what is happening
                    Console.WriteLine("Executing a While Loop!");
                    Console.WriteLine("The While Loop will iterate " + input_value.ToString() + " times.");

                    // Begin While Loop
                    while (input_value > 0)
                    {
                        // Tell user what the value is
                        Console.WriteLine("The value of the iterative variable is " + input_value.ToString());

                        // Change input_value for next iteration
                        input_value--;
                    }  // End While Loop

                    // Ask user to press key to exit program
                    Console.WriteLine("Press any key to exit the program.");
                    // Take input from user
                    Console.ReadKey(true);
                } // End Else If 1

                // If the Input Value is between 10 and 20, execute a Do While Loop
                else if ((input_value > 10) && (input_value <= 20))
                {
                    //Write lines that convey to the user what is happening
                    Console.WriteLine("Executing a Do While Loop!");
                    Console.WriteLine("The Do While Loop will iterate " + input_value.ToString() + " times.");

                    // Begin Do While Loop
                    do
                    {
                        // Tell user what the value is
                        Console.WriteLine("The value of the iterative variable is " + input_value.ToString());

                        // Change input_value for next iteration
                        input_value--;
                    } while (input_value > 0); // End Do While Loop

                    // Ask user to press key to exit program
                    Console.WriteLine("Press any key to exit the program.");
                    // Take input from user
                    Console.ReadKey(true);
                } // End Else If 2

                // Display message if user does not enter an integer between 1 and 20
                else
                {
                    Console.WriteLine("Please enter an integer between 1 and 20 and try again ...");
                    // Ask user to press key to exit program
                    Console.WriteLine("Press any key to exit the program and try again ...");
                    // Take input from user
                    Console.ReadKey(true);
                } // End Else
            } // End Try

            // In case of error, perform the following statements
            catch
            {
                Console.WriteLine("Please enter and integer value and try again ...");
                // Ask user to press key to exit program
                Console.WriteLine("Press any key to exit the program and try again ...");
                // Take input from user
                Console.ReadKey(true);
            } // End Catch
        } // End Main
    } // End Class
} // End namespace