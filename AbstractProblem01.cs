using System;

namespace ConsoleApp50
{
  abstract class ABC
  {
    public abstract void FirstMethod();
    public abstract void SecondMethod();
    
  }

  class DEF : ABC
  {
    public override void FirstMethod()
    {
      Console.WriteLine("first Override method");
    }
    public override void SecondMethod()
    {
      Console.WriteLine("Second Override method");
    }
  }
  class Program
  {
    static void Main()
    {
      DEF def = new DEF();
      def.FirstMethod();
      def.SecondMethod();
    }
  }
}
