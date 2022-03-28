using System;
using System.IO;  // include the System.IO namespace

namespace _8_StreamsFilesDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            FileMethod();
        }

        //AppendText()    Appends text at the end of an existing file
        //Copy()  Copies a file
        //Delete()    Deletes a file
        //Exists()    Tests whether the file exists
        //ReadAllText()   Reads the contents of a file
        //Replace()   Replaces the contents of a file with the contents of another file
        //WriteAllText()  Creates a new file and writes the contents to it.
        //If the file already exists, it will be overwritten.
        public static void FileMethod()
        {

            string writeText = "Hello World!";  // Create a text string

            //Create()    Creates or overwrites a file
            File.Create("C:/Users/HP/Desktop/basic.txt");
            File.WriteAllText("basic.txt", writeText);  // Create a file and write the content of writeText to it

            string readText = File.ReadAllText("basic.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the con

        }

    }
}
