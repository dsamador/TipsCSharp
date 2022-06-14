int a = 0;
int b = 0;

bool r1 = false;
bool r2 = false;

for (a = 0; a < 2; a++)
{
    for (b = 0; b < 2; b++)
    {
        //r1 = (a == 0 && b == 1) || b == 0;
        //r2 = a == 0 && b == 1 || b == 0;

        r1 = (a == 0 || b == 1) && a == 1;
        r2 = a == 0 || b == 1 && a == 1;

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"{a} {b}");

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($" {r1} ");

        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine($"{r2}");
    }
}