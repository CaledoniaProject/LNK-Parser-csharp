using ShellLink;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                Shortcut.ReadFromFile(@"C:\calc.exe.lnk")
            );
        }
    }
}
