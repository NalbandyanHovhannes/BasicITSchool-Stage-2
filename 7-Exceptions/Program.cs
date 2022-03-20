using System;

namespace _7_Exceptions
{
    class Program
    {
        static void ProcessString(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException(paramName: nameof(s), message: "parameter can't be null.");
            }
        }

        public static void Main()
        {
            string s = null; // For demonstration purposes.

            try
            {
                ProcessString(s);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
        }
    }
}
