using System;

namespace MulticastDelegateExample
{
    // Step 1: Define a delegate
    public delegate void Notify();

    class Program
    {
        // Step 2: Define methods that match the delegate signature
        public static void MethodOne()
        {
            Console.WriteLine("Method One is called.");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("Method Two is called.");
        }

        /*static void Main(string[] args)
        {
            // Step 3: Create a multicast delegate instance
            Notify notify;

            // Add methods to the delegate
            notify = MethodOne;
            notify += MethodTwo;

            // Step 4: Invoke the delegate
            Console.WriteLine("Invoking the multicast delegate:");
            notify();

            // Step 5: Remove a method from the delegate
            notify -= MethodOne;

            Console.WriteLine("\nInvoking after removing MethodOne:");
            notify();

            Console.ReadKey();
        }*/
    }
}
