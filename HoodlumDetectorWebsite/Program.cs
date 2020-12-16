using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

// Write a method that appends to the top lines of a file, to write time logs into a file. it logs every 5seconds....no hoodlum in sight.
namespace HoodlumDetectorWebsite
{
    internal class Program
    {
        private static void Main() // not complete
        {
            const string message = "<h1>No hoodlums in sight</h1>";
            const string filePath = "C:\\Users\\JamesMorgan\\Desktop\\hoodlums.html";
            var dateTime = DateTime.Now;
            File.AppendAllText(filePath, $"{message}<p>{dateTime:T}</p>");
            LaunchFile(filePath);

            while (true)
            {
                Thread.Sleep(5000);
                var currentTime = DateTime.Now;
                var newMessage = $"{message}<p>{currentTime:T}</p>";
                File.AppendAllText(filePath, newMessage);
            }
        }

        private static void LaunchFile(string filePath) // to open the file after the user has completed the blog
        {
            Console.WriteLine("\nAny minute now...");
            Thread.Sleep(1000);
            Process.Start(filePath);
        }

        private static Stack<string> PrependMessages(List<string> messages)
        {
            var messageStack = new Stack<string>();
            foreach (var message in messages)
            {
                var today = DateTime.Now;
                var newMessage = $"<h1>{message}</h1><p>{today:T}</p>";
                Console.WriteLine(newMessage);
                //messages.Add(newMessage);
            }
            return messageStack;
        }

        private static string PrepareMessages(string rawMessage)
        {
            var newMessage = rawMessage;
            return newMessage;
        }

        //private static IEnumerable<string> PrependMessage(IEnumerable<string> messages)
        ////{
        //    return messagesStack;
        //}
    }
}