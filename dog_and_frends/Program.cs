Console.Write("Input distance(meters): ");
int distance = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of first friend(m/sec): ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of second friend(m/sec): ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of a dog(m/sec): ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int count = 0, friend = 2, time = 0;

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
}

Console.WriteLine("THe dog ran " + count + " times.");