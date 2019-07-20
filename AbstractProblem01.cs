using System;

namespace ConsoleApp50
{
  abstract class ABC
  {
    public abstract void FirstMethod();
    void SecondMethod()
    {
      Console.WriteLine("Second method");
    }
  }

  class DEF : ABC
  {
    public override void FirstMethod()
    {
      Console.WriteLine("Second Override method");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
