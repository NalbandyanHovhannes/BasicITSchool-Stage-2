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

            Testing1 test = new Testing1();
            test.Method1();

            //2nd step
            try
            {
                int i = test.RecursiveMethod();
            }
            catch (System.Exception e)
            {

            }
            finally
            {

            }





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
