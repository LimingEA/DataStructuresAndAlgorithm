using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static void TestReadingFile()
        {
            var memoryBefore = GC.GetTotalMemory(true);
            StreamReader sr;
            try
            {
                sr = File.OpenText("c:\\temp\\tempFile.txt");

            }
            catch(FileNotFoundException)
            {
                Console.WriteLine(@"这个例子需要一个名为c:\\temp\\tempFile.txt的文件");
            }
            var fileContents = new List<string>();
            while(!sr.EndOfStream)
            {
                fileContents.Add(sr.ReadLine());
            }
            var stringsFound =
                from line in fileContents
                where line.Contains("人工智能")
                select line;
            sr.Close();
            Console.WriteLine("数量:" + stringsFound.Count());
            var memoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("数量："+stringsFound.Count)
        }
    }
}
