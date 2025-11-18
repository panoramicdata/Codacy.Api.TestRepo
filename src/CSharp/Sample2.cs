using System;

namespace Codacy.Api.TestFixtures
{
    public class Sample2
    {
        // Public field instead of property - bad practice
        public string PublicField;

        public Sample2()
        {
            PublicField = "Should be a property";
        }

        // No parameter validation
        public void ProcessData(string data)
        {
            var length = data.Length; // Potential null reference
            Console.WriteLine($"Data length: {length}");
        }

        // Hardcoded strings - should be constants
        public void PrintMessages()
        {
            Console.WriteLine("Error occurred");
            Console.WriteLine("Warning: something happened");
            Console.WriteLine("Info: process started");
        }
    }
}
