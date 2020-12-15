using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

// Use this blog website generator to create an html file that asks for a user name, file name, blog content and date published.
//collect name of file
//create file
//add a heading
// enter the body
// enter my footer
// Write a method that appends to the top lines of a file, to write time logs into a file. it logs every 5seconds....no hoodlum in site.
namespace InputOutput
{
    internal class Program
    {
        private static DateTime _today = DateTime.Now;

        private static void Main()
        {
            GreetUser();
            Console.WriteLine("\nSo, what's your name? This will serve as your username");
            var userName = Console.ReadLine();
            Console.WriteLine("What would you like the file name to be?");
            var blogName = Console.ReadLine();
            var filePath = $"C:\\Users\\JamesMorgan\\Desktop\\SystemIO\\{blogName}.html";
            File.AppendAllText(filePath, $"<h1>Hi my name is {userName} Welcome to my blog</h1>");

            Console.WriteLine("\nEnter the headline for your blog post");
            var heading = Console.ReadLine();
            File.AppendAllText(filePath, $"<h2>{heading}</h2>");

            var allContent = new List<string>();
            Console.WriteLine("\nNow type the content of the post");
            var typing = true;
            do
            {
                var body = Console.ReadLine();
                allContent.Add($"<p>{body}</p>");
                Console.WriteLine("Do you wish to add more content?");
                var typingChoice = Console.ReadLine().ToLower();
                if (typingChoice == "no")
                {
                    typing = false;
                }
            } while (typing);

            File.AppendAllLines(filePath, allContent);
            File.AppendAllText(filePath, $"<p>Date Published: {_today:f}</p>");
            Console.WriteLine("Nicely done. Now let's see your new website! You can share with your friends");
            LaunchFile(filePath);
        }

        private static void LaunchFile(string filePath) // to open the file after the user has completed the blog
        {
            Console.WriteLine("\nAny minute now...");
            Thread.Sleep(2000);
            Process.Start(filePath);
        }

        private static void GreetUser()
        {
            Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t        {_today:f}");
            if (_today.Hour < 12)
            {
                Console.WriteLine("Good morning this is a blog generator program for that topic you've always wanted to post");
                Console.WriteLine("I hope you enjoy using it as much as I enjoyed building it for you");
            }
            else if (_today.Hour >= 12 && _today.Hour <= 18)
            {
                Console.WriteLine("Good afternoon this is a blog generator program for that topic you've always wanted to post");
                Console.WriteLine("I hope you enjoy using it as much as I enjoyed building it for you");
            }
            else
            {
                Console.WriteLine("Good evening this is a blog generator program for that topic you've always wanted to post");
                Console.WriteLine("I hope you enjoy using it as much as I enjoyed building it for you");
            }
        }
    }
}