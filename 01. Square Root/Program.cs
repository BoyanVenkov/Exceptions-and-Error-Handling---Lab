try
{
    int n = int.Parse(Console.ReadLine());

    if (n < 0)
    {
        Console.WriteLine("Invalid number.");
    }
    else
    {
        Console.WriteLine(Math.Sqrt(n));
    }
}
catch
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}