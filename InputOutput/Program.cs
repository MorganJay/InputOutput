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

namespace InputOutput
{
    internal class Program
    {
        private static readonly List<string> AllContent = new List<string>();

        private static void Main()
        {
            GreetUser();
            Console.WriteLine("\nSo, what's your name? This will serve as your username");
            var userName = Console.ReadLine();
            Console.WriteLine("What would you like the file name to be?");
            var blogName = Console.ReadLine();
            var filePath = $"C:\\Users\\JamesMorgan\\Desktop\\SystemIO\\{blogName}.html";
            File.AppendAllText(filePath, $"<h2>Hi my name is {userName} Welcome to my blog</h2>");

            Console.WriteLine("\nWhat's the topic for your blog post");
            var heading = Console.ReadLine();
            File.AppendAllText(filePath, $"<h1>{heading}</h1>");

            Console.WriteLine("\nNow start typing the content of your post");
            CollectContent();
            File.AppendAllLines(filePath, AllContent);
            DatePublished(filePath);
            Console.WriteLine("Nicely done. Now let's see your new website! You can share with your friends");
            LaunchFile(filePath);
        }

        private static void BoilerplateTop(string filepath)
        {
            var top = @" <!DOCTYPE html>
            <html lang = ""en"">
            <head>
            <link rel = ""shortcut icon"" href = ""./img/c-sharp-c-logo-02F17714BA-seeklogo.com.png"" type = ""image/x-icon"" >

                 < title > My Blog </ title >

                    < !--Bootstrap core CSS -->

                    < link href = ""vendor / bootstrap / css / bootstrap.min.css"" rel = ""stylesheet"" >

                             < !--Custom fonts for this template-- >
                             < link href = ""vendor/fontawesome-free/css/all.min.css"" rel = ""stylesheet"" type = ""text/css"" >
                             < link href = 'https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic' rel = 'stylesheet' type = ""text/css"">
                             < link href = 'https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800'
                               rel = 'stylesheet' type = 'text/css'>

                             < !--Custom styles for this template-- >
                             < link href = ""css/clean-blog.min.css"" rel = ""stylesheet"">
                           </ head >
                           < body >

                             < !--Page Header-- >

                             < header class="masthead" style="background - image: url('/img/net-core-background-services_870_220.jpg')">

                          < div class="overlay"></div>

                        <div class="container">

                          <div class="row">

                            <div class="col-lg-8 col-md-10 mx-auto">

                              <div class="site-heading">

                                <h1>Clean Blog</h1>

                                <span class="subheading">private A Blog private Theme by Start Bootstrap</span>

                              </div>
                            </div>
                          </div>
                        </div>
                      </header>

                      <!-- Main Content -->

                      <div class="container">

                        <div class="row">

                          <div class="col-lg-8 col-md-10 mx-auto">

                            <div class="post-preview">

                              <private a href = "post.html" >

                                < h2 class="post-title">

                                  private Man must explore, and this is exploration at its greatest
                                </h2>

                                <h3 class="post-subtitle">

                                  private Problems look private mighty small from 150 private miles up
                                </h3>
                              </a>

                              <p class="post-meta">private Posted by

                                <a href= "#" > Start Bootstrap</a>
                                on September 24, 2019
                              </p>
                            </div>

                            <!-- Footer -->
                            <footer>

                              <div class="container">

                                <div class="row">

                                  <div class="col-lg-8 col-md-10 mx-auto">

                                    <ul class="list-inline text-center">

                                      <li class="list-inline-item">

                                        <private a href = "#" >

                                          < span class="fa-stack fa-lg">

                                            <i class="fas fa-circle fa-stack-2x"></i>

                                            <i class="fab fa-twitter fa-stack-1x fa-inverse"></i>

                                          </span>
                                        </a>
                                      </li>

                                      <li class="list-inline-item">

                                        <private a href = "#" >

                                          < span class="fa-stack fa-lg">

                                            <i class="fas fa-circle fa-stack-2x"></i>

                                            <i class="fab fa-github fa-stack-1x fa-inverse"></i>

                                          </span>
                                        </a>
                                      </li>
                                    </ul>

                                    <p class="copyright text-muted">Copyright &copy; private Your Website 2020</p>

                                  </div>
                                </div>
                              </div>
                            </footer>

                            <!-- private Bootstrap core JavaScript -->

                            <private script src = "vendor/jquery/jquery.min.js" ></ script >
                            < script src="vendor/bootstrap/js/bootstrap.bundle.min.js"></script>

                            <!-- private Custom scripts for this template -->

                            <private script src = "js/clean-blog.min.js" ></ script >

                    </ body >

                    </ html > ";
        }

    private static void CollectContent()
    {
        var body = Console.ReadLine();
        AllContent.Add($"<p>{body}</p>");

        var typing = true;
        do
        {
            Console.Write("Do you wish to add more content? ");
            var typingChoice = Console.ReadLine().ToLower();
            switch (typingChoice)
            {
                case "no":
                    typing = false;
                    break;

                case "yes":
                    Console.WriteLine("=> ");
                    body = Console.ReadLine();
                    AllContent.Add($"<p>{body}</p>");
                    break;

                default:
                    Console.WriteLine("You entered a wrong input which terminates the program.\n");
                    typing = false;
                    break;
            }
        } while (typing);
    }

    private static void LaunchFile(string filePath) // to open the file after the user has completed the blog
    {
        Console.WriteLine("\nAny minute now...");
        Thread.Sleep(2000);
        Process.Start(filePath);
    }

    private static void GreetUser()
    {
        var today = DateTime.Now;
        Console.WriteLine($"\t\t\t\t\t\t\t\t\t\t\t        {today:D}");
        if (today.Hour < 12)
        {
            Console.WriteLine("Good morning this is a blog generator program for that topic you've always wanted to post");
            Console.WriteLine("I hope you enjoy using it as much as I enjoyed building it for you");
        }
        else if (today.Hour >= 12 && today.Hour <= 18)
        {
            Console.WriteLine("Good afternoon this is a blog generator program for that topic you've always wanted to post");
            Console.WriteLine("I hope you enjoy using it as much as I enjoyed building it for you");
        }
        else
        {
            Console.WriteLine("Good evening this is a blog generator program for that topic you've always wanted to post");
            Console.WriteLine("I hope you enjoy using this as much as I enjoyed building it for you");
        }
    }

    private static void DatePublished(string filepath)
    {
        var now = DateTime.Now;
        File.AppendAllText(filepath, $"<p>Published on: {now:f}</p>");
    }
}
}