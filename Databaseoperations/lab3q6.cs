using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosaDatabaseoperations
{

    // Step 1: Define a custom exception by inheriting from Exception
    public class InvalidAgeException : Exception
        {
            // Constructor to pass a custom message to the base Exception class
            public InvalidAgeException(string message) : base(message)
            {
            }
        }

        class lab3q6
        {
            /*static void Main(string[] args)
            {
                Console.WriteLine("Welcome to the Age Verification Program!");

                try
                {
                    Console.Write("Enter your age: ");
                    int age = int.Parse(Console.ReadLine());

                    // Check for invalid age
                    if (age < 0 || age > 150)
                    {
                        // Step 2: Throw the custom exception
                        throw new InvalidAgeException("Age must be between 0 and 150.");
                    }

                    Console.WriteLine("Age verified successfully!");
                }
                catch (InvalidAgeException ex)
                {
                    // Step 3: Handle the custom exception
                    Console.WriteLine($"Custom Exception Caught: {ex.Message}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error: Please enter a valid numeric value.");
                }
                finally
                {
                    Console.WriteLine("Thank you for using the Age Verification Program.");
                }
            }*/
        }
    }


