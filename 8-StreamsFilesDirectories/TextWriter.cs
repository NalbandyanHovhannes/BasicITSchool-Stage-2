using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}
