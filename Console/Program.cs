using System;
using Wex.Context;
using Microsoft.EntityFrameworkCore.Design;
using System.Linq;

namespace Wex.Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (WexContext context = new WexContext())
            {
                
            }
        }
    }
}
