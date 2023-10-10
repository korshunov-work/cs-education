Console.Clear();

int xa = 50, ya = 1,
    xb = 1, yb = 30,
    xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+"); 

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = xb;

for (int i = 0; i < 10000; i++)
{
    int dot = new Random().Next(0, 3);
    if (dot == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    
    if (dot == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    
    if (dot == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");    
}