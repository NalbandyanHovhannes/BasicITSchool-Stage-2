using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Exceptions
{
    class TryCatchFinnally
    {
       public void ReadFile(int index)
        {

         
                // To run this code, substitute a valid path from your local machine
                string path = @"C:\Users\HP\Desktop\888.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path);
            try
            {
                char[] buffer = new char[10];
          
                file.ReadBlock(buffer, index, buffer.Length);
            }
            catch (System.IO.IOException e)
            {
                Console.WriteLine("Error reading from {0}. Message = {1}", path, e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
            // Do something with buffer...
        }

    }
}
