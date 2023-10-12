Console.Clear();

int distance = 20001;
int distanceBetween = distance;
int scale = 200;

while (distance > 20000 || distance < 0)
{
    Console.Clear();
    Console.Write("Input distance (meters. <= 20000): ");
    distance = Convert.ToInt32(Console.ReadLine());
    distanceBetween = distance;
}

if (distance <= 1000)
{
    scale = 10;
}
if (distance > 1000 && distance <= 5000)
{
    scale = 25;
}
if (distance > 5000 && distance <= 10000)
{
    scale = 50;
}
if (distance > 10000)
{
    scale = 100;
}

Console.Write("Input speed of first friend (m/sec): ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of second friend (m/sec): ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of a dog (m/sec): ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int count = 0, friend = 2, time = 0, time2 = 0;

Console.Clear();
Console.SetCursorPosition(0, 1);
Console.WriteLine("▓");
Console.SetCursorPosition(distance / scale, 1);
Console.WriteLine("▓");
Console.SetCursorPosition(1, 1);
Console.WriteLine("@");

for (int i = 0; i < distanceBetween / scale; i++)
{
    Console.SetCursorPosition(i, 2);
    Console.WriteLine("-");
}

Console.SetCursorPosition(0, 3);
Console.WriteLine("Distance - " + distanceBetween + " meters");

await Task.Delay(1000);

while (distance > 10)
{
    if (friend == 1)
    {
        time = distance / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distance -= (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
    time2 += time;

    Console.Clear();
    Console.SetCursorPosition(1, 1);
    if (friend == 2)
    {
        Console.SetCursorPosition(((0 + time2 * firstFriendSpeed) / scale) + 1, 1);
        Console.WriteLine("@");
    }
    else
    {
        Console.SetCursorPosition(((distanceBetween - time2 * secondFriendSpeed) / scale) - 1, 1);
        Console.WriteLine("@");
    }

    Console.SetCursorPosition((0 + time2 * firstFriendSpeed) / scale, 1);
    Console.WriteLine("▓");
    Console.SetCursorPosition((distanceBetween - time2 * secondFriendSpeed) / scale, 1);
    Console.WriteLine("▓");

    for (int i = 0; i < distanceBetween / scale; i++)
    {
        Console.SetCursorPosition(i, 2);
        Console.WriteLine("-");
    }

    Console.SetCursorPosition(0, 3);
    Console.WriteLine("Distance - " + distanceBetween + " meters");

    await Task.Delay(1000);
}

Console.WriteLine("The dog ran " + count + " times.");