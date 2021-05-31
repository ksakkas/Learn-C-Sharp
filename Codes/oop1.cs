using System;

namespace MyApplication
{
  class name
  {
    string mname = "Konstantinos";
    string lname = "Sakkas";


    static void Main(string[] args)
    {
      name obj1 = new name();
      name obj2 = new name();
      Console.WriteLine(obj1.mname);
      Console.WriteLine(obj2.lname);
    }
  }
}
