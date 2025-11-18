using System;
using System.Collections.Generic;

namespace Codacy.Api.TestFixtures
{
    /// <summary>
    /// Sample C# file with intentional code quality issues for testing
    /// </summary>
    public class Sample1
    {
        // Unused variable - will trigger code quality issue
        private string unusedField = "This field is never used";

        public void MethodWithIssues()
        {
            // Unused variable
            var unusedVariable = "This will trigger a warning";
            
            // Magic number
            var result = 42 * 100;
            
            // Empty catch block - bad practice
            try
            {
                var data = GetData();
            }
            catch (Exception)
            {
                // TODO: Handle this properly
            }
            
            Console.WriteLine("Method completed");
        }

        public string GetData()
        {
            return "Sample data";
        }

        // Method too complex
        public int ComplexMethod(int a, int b, int c)
        {
            if (a > 0)
            {
                if (b > 0)
                {
                    if (c > 0)
                    {
                        return a + b + c;
                    }
                    else
                    {
                        return a + b - c;
                    }
                }
                else
                {
                    return a - b + c;
                }
            }
            else
            {
                return -a + b + c;
            }
        }
    }
}
