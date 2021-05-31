static int addint(int x, int y)
{
  return x + y;
}

static double adddb(double x, double y)
{
  return x + y;
}

static void Main(string[] args)
{
  int addn = addint(8, 5);
  double addd = adddb(4.3, 6.26);
  Console.WriteLine("Int: " + addn);
  Console.WriteLine("Double: " + addd);
}
