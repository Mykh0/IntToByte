using System;

namespace ConvertToByte
{
  class Program
  {
    static void Main(string[] args)
    {
      int input = Convert.ToInt32(Console.ReadLine());

      input = input > 255 ? 255 : input;
      input = input < 0 ? 0 : input;

      Console.WriteLine(Convert.ToString(input, 2).PadLeft(8, '0'));
      Console.ReadLine();
    }
  }
}
