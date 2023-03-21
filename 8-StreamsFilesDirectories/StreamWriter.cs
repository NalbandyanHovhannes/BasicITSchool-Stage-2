using System;
using System.IO;

namespace _8_StreamsFilesDirectories
{

    //The StreamWriter class in C# is used for writing characters to a stream.
    //It uses the TextWriter class as a base class and provides the overload methods for writing data into a file.    
    //The StreamWriter is mainly used for writing multiple characters of data into a file.
    class StreamWriterr
    {
        public void StreamMethod()
        {
            FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);
            Console.WriteLine("File opened");           
            //declared stream writer
            StreamWriter s = new StreamWriter(f);
            Console.WriteLine("Writing data to file");
            s.WriteLine("Writing data into file using stream writer");

            //closing stream writer
            s.Close();
            f.Close();
            Console.WriteLine("File Stream closed");
            Console.ReadLine();
        }
    }
}


