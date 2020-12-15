using System;
using System.IO;

// Use this blog website generator to create an html file that asks for a user name, file name, blog content and date published.
// Write a method that appends to the top lines of a file, to write time logs into a file. it logs every 5seconds....no hoodlum in site.
namespace InputOutput
{
    internal class Program
    {
        private static void Main()
        {
            const string filePath = "C:\\New folder\\daniel.html";
            LowLevelWrite(filePath);
            var innerText = File.ReadAllText(filePath);

            //Console.WriteLine(innerText);
            Console.ReadLine();
        }

        private static void LowLevelWrite(string path)
        {
            //var str = new StreamWriter(path);
            //str.WriteLine("This is from me");
            //str.WriteLine("This is amazing");
            using (var str = new StreamWriter(path))
            {
                //str.WriteLine("This is from me");
                //str.WriteLine("This is amazing");
                str.WriteLine("<h1>Hello Daniel!</h1>");
                str.Close();
            }
            //ile.AppendAllText(path, "This is an appended line");
            //File.WriteAllLines(path, "");
            File.ReadAllText(path);
        }
    }
}