// See https://aka.ms/new-console-template for more information
using DetachedConsoleDemo;
using System.Diagnostics;

if (ConsoleExt.ConsoleOwnerProcessId != Process.GetCurrentProcess().Id)
{
    ConsoleExt.Free();
    ConsoleExt.Alloc();
}

Console.WriteLine("Hello, World!");
Console.ReadLine();
