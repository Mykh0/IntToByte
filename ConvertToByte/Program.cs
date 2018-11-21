using System;

namespace ConvertToByte
{
  class Program
  {
    static void Main(string[] args)
    {
      int input = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(Convert.ToString(input, 2).PadLeft(8, '0'));
    }
  }
}
