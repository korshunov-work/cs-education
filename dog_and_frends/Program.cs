Console.Clear();
int distance = 10001;
int distance2 = distance;

while (distance > 10000 || distance < 0)
{
    Console.Clear();
    Console.Write("Input distance (meters. <= 10000): ");
    distance = Convert.ToInt32(Console.ReadLine());
    distance2 = distance;
}
 
Console.Write("Input speed of first friend (m/sec): ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of second friend (m/sec): ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of a dog (m/sec): ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int count = 0, friend = 2, time = 0, time2 = 0, x = 40;

Console.Clear();
Console.SetCursorPosition(0, 1);
Console.WriteLine("8");
Console.SetCursorPosition((distance / x), 1);
Console.WriteLine("8");
Console.SetCursorPosition(1, 1);
Console.WriteLine("@");
await Task.Delay(1000);

while (distance > 100)
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
    time2 = time2 + time;

    Console.Clear();
    Console.SetCursorPosition(1, 1);
    if (friend == 2)
    {
        Console.SetCursorPosition(((0 + time2 * firstFriendSpeed) / x) + 1, 1);
        Console.WriteLine("@");      
    }
    else
    {
        Console.SetCursorPosition(((distance2 - time2 * secondFriendSpeed) / x) - 1, 1);
        Console.WriteLine("@");
    }
    
    Console.SetCursorPosition((0 + time2 * firstFriendSpeed) / x, 1);
    Console.WriteLine("8");
    Console.SetCursorPosition((distance2 - time2 * secondFriendSpeed) / x, 1);
    Console.WriteLine("8");

    await Task.Delay(1000);
}

Console.WriteLine("The dog ran " + count + " times.");