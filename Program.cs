using System;

namespace HelloDotNet
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter Name:");
      string username= Console.ReadLine();
      Console.WriteLine("Hello, World, my name is" + username);
    }
  }
}
