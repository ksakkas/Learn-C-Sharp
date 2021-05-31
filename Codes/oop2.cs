using System;

namespace MyApplication
{
  class house 
  {
    string color;
    int height;

    static void Main(string[] args)
    {
      Car obj = new house();
      obj.color = "white";
      obj.height = 2000;
      Console.WriteLine(obj.color);
      Console.WriteLine(obj.height);
    }
  }
}
