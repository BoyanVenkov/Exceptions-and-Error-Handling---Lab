using System;

int start = 1;
int end = 100;

ReadNumber(start, end);

static void ReadNumber(int start, int end)
{
    List<int> output = new List<int>();
    int count = 0;
    int currentNum = start;
    while (count < 10)
    {
        string input = Console.ReadLine();

        try
        {
            int num = int.Parse(input);

            if (num <= start || num >= end)
            {
                Console.WriteLine($"Your number is not in range {currentNum} - 100!");
                continue;
            }

            output.Add(num);
            start = num;
            count++;
            currentNum = num;
        }
        catch
        {
            Console.WriteLine("Invalid Number!");
        }
    }

    Console.WriteLine(string.Join(", ", output));
}
