# LNK-Parser-csharp

This repo is a combination of [ShellLink](https://github.com/securifybv/ShellLink) and [ShellLink](https://github.com/securifybv/ShellLink) library. I have implemented StructuralComparisons and made several changes to make this library compatible with .NET 3.5.

Example usage:

```
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
```

