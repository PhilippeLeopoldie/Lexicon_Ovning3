// See https://aka.ms/new-console-template for more information

/*
 
----------------
Installed an ASP.NET Core HTTPS development certificate.
To trust the certificate, run 'dotnet dev-certs https --trust'
Learn about HTTPS: https://aka.ms/dotnet-https

----------------
Write your first app: https://aka.ms/dotnet-hello-world
Find out what's new: https://aka.ms/dotnet-whats-new
Explore documentation: https://aka.ms/dotnet-docs
Report issues and find source on GitHub: https://github.com/dotnet/core
Use 'dotnet --help' to see available commands or visit: https://aka.ms/dotnet-cli
 */

using System.Security.Cryptography.X509Certificates;
using System.Text;
using CodeTraining;

namespace CodeTraining;
public static class Program{



public static void Main(string[] args) {
        //Console.WriteLine(CodeChallenges.getGreatestNumber(new int[]{1,2,9,1,1,3,0}));
        Console.WriteLine(CodeChallengesKattis.Fibonacci(6));
        //Console.WriteLine("The Name Game");
        //Console.Write("What's your first name?");
    }
}




