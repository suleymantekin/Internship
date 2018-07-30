using System;
using Mod2_Lab1_Sakila.Models;
using System.Linq;
namespace Mod2_Lab1_Sakila
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new sakilaContext();
            var actors = dbContext.Actor.ToList();
            foreach (var a in actors)
            {
                System.Console.WriteLine($"ID:{a.ActorId} Name:{a.FirstName} {a.LastName}");
            }
        }
    }
}
