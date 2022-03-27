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
            try
            {
                int[] array = new int[2];
                array[3] = 2;
                var r=array[1]/int.Parse( Console.ReadLine());
                Console.WriteLine("error in try block");
                if (r>0)
                {
                    throw new Exception("its a Govnocode");
                }

            }
            catch ( Exception ex)
            {
                Console.WriteLine("error in catch block"+ex.Message);
              
            }
           
            finally {
                Console.WriteLine("error in finally block" );
            }







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
