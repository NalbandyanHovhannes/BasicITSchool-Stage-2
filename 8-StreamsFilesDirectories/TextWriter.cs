using System;
using System.IO;

namespace _8_StreamsFilesDirectories
{
    class TextWriterr
    {
        public void TextWriterMethod()
        {
            using (TextWriter writer = File.CreateText("d:\\textFile.txt"))
            {

                writer.WriteLine("The first line with text writer");
            }

            using (TextReader txtR = File.OpenText("d:\\textFile.txt"))
            {

                String data = txtR.ReadToEnd();
                Console.WriteLine(data);
            }
            Console.ReadLine();
        }
    }
}
