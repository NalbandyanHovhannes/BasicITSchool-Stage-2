using System;
using System.IO;

namespace _8_StreamsFilesDirectories
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileMethod();
        }

        //AppendText()    Appends text at the end of an existing file
        //Copy()  Copies a file
        //Delete()    Deletes a file2
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
                File.WriteAllText("basic.txt", "Hello World!");  // Create a file and write the content of writeText to it

            }
            //Delete file
            File.Delete(path);
            //create
            File.Create("C:/Users/HP/Desktop/basic1.txt");
            //copy
            //create Matrix

            //replace
            File.Copy(path, path.Replace("1.txt", @"1\\1.txt"));

            //move
            File.Move(path, path.Replace("1.txt", @"1\\1.txt"), true);

            //file create close
            File.Create(path).Close();

            //file dispose
            File.Create(path).Dispose();

            string readText = File.ReadAllText("basic.txt");  // Read the contents of the file
            Console.WriteLine(readText);  // Output the con

            //////////////////////FileStream ///            ///
            ///
            string path2 = @"C:\Users\HP\Desktop\basic.txt";

            FileStream file = new FileStream(path2, FileMode.OpenOrCreate);
            file.Seek(0, SeekOrigin.End);
            file.Close();

            StreamWriter stream = new StreamWriter(file);
            stream.WriteLine("666");

            stream.Close();
            file.Close();

            //using
        }

    }

}
//FileStream is a Stream.Like all Streams it only deals with byte[] data.
//A StreamWriter : TextWriter is a Stream-decorator.A TextWriter encodes the primitive
//type like string, int and char to byte[] and then writes hat to the linked Stream.
//What context are you supposed to use it? What is their advantage and disadvantage?u
//You use a bare FileStream when you have byte[] data. You add a StreamWriter when you want to
//write text. Use a Formatter or a Serializer to write more complex data.

//Stream is an abstract class for transfering bytes from different sources.It is base class
//for all other class that reads\writes bytes to different sources.
//FileStream class provides reading and writing functionality of bytes to physical file.
//Reader & writer classes provides functionality to read bytes from Stream classes
//(FileStream, MemoryStream etc) and converts bytes into appropriate encoding.


//StreamReader provides a helper method to read string from FileStream by
//converting bytes into strings. StreamWriter provides a helper method to write string to
//FileStream by converting strings into bytes.


//A FileStream refers to the bytes being written to a file, similar to how a
//MemoryStream refers to the bytes written to an in-memory buffer. In order to
//write characters to a stream, you'd need to convert them to a string of bytes.
//That's where a StreamWriter comes in to play. It takes a sequence of characters
//and an encoding, and turns it into a sequence of bytes.


//A TextWriter is an interface (well, abstract base class) that all of the Writers
//must adhere to. It has all operations based on characters. The equivalent for bytes
//is the Stream abstract base class.

//Things also go in the opposite direction. There is a TextReader abstract base class,
//describing how to read characters from somewhere, and a StreamReader, which allows you
//to read characters from a byte-oriented stream supplying an encoding - but this time
//used in reverse, to aggregate any multi-byte sequences into single characters where appropriate.


//A Stream can be used for both reading and writing, since bytes are the lowest-level
//items used in I/O operations.