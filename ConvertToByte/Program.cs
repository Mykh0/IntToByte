using System;

namespace ConvertToByte
{
  class Program
  {
    static void Main(string[] args)
    {
      double theta = Convert.ToDouble(args[0]);

      double d = 2.466;
      double c = 343;
      double fs = 48000;

      double n_samples = (d * fs * Math.Sin(Math.PI * theta / 180)) / c;

      int input = Convert.ToInt32(n_samples);

      input = input > 255 ? 255 : input < 0 ? 0 : input;

      Console.WriteLine(input);
    }
  }
}
