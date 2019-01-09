using System;

namespace ConvertToByte
{
  class Program
  {
    static void Main(string[] args)
    {
      int input = Convert.ToInt32(args[0]);

      input = Convert.ToInt32(Convert.ToDouble(input) / 100 * 255);
      input = input > 255 ? 255 : input < 0 ? 0 : input;

      Console.WriteLine(Convert.ToString(input, 2).PadLeft(8, '0'));
    }
  }
}
