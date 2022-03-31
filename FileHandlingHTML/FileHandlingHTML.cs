using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingHTML
{
    internal class FileHandlingHTML
    {
        public void ReadFile1()
        {
            FileStream fileStream = new FileStream(@"C:\Training\mydata.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileStream);
            int count = 0;
            string Word = "<input";
            while (reader.Peek() > 0)
            {
                string line = reader.ReadLine();
                if (line.Contains(Word))
                {
                    Console.WriteLine(line);
                    count++;
                }
            }
            Console.WriteLine("Number of <input = " + count);
            reader.Close();
            fileStream.Close();
        }
    }
}
