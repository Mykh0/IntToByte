using System;

namespace ConvertToByte
{
  class Program
  {
    static void Main(string[] args)
    {
      int input = Convert.ToInt32(args[0]);

      input = input > 255 ? 255 : input < 0 ? 0 : input;
      input = Convert.ToInt32((Convert.ToDouble(input) / 100) * 255);
      Console.WriteLine(input);
    }
  }
}
