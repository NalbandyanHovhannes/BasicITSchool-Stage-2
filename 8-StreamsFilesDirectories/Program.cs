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
            string path = @"C:\Users\HP\Desktop\basic.txt";
            if (File.Exists(path))
            {
            File.WriteAllText("basic.txt", writeText);  // Create a file and write the content of writeText to it

            }
            //Delete file
            File.Delete(path);
            //create
            File.Create("C:/Users/HP/Desktop/basic1.txt");
            //copy
            //create Matrix

            //replace
            File.Copy(path,path.Replace("1.txt",@"1\\1.txt"));

            //move
            File.Move(path, path.Replace("1.txt", @"1\\1.txt"),true);


            //file create close
            File.Create(path).Close();

            //file dispose
            File.Create(path).Dispose();




            string readText = File.ReadAllText("basic.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the con





            //////////////////////FileStream
            ///
            string path2 = @"C:\Users\HP\Desktop\basic.txt";

            FileStream file = new FileStream(path2,FileMode.OpenOrCreate);
            file.Seek(0,SeekOrigin.End);
            file.Close();

            StreamWriter stream = new StreamWriter(file);
            stream.WriteLine("666");

            stream.Close();
            file.Close();

            


        }

    }
}
