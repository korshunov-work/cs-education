Console.Clear();

Console.Write("Input distance (meters): ");
int distance = Convert.ToInt32(Console.ReadLine());
int distanceBetween = distance;
int distanceGraph = distance;
int step = distanceBetween / 200;

Console.Write("Input speed of first friend (m/sec): ");
int firstFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of second friend (m/sec): ");
int secondFriendSpeed = Convert.ToInt32(Console.ReadLine());

Console.Write("Input speed of a dog (m/sec): ");
int dogSpeed = Convert.ToInt32(Console.ReadLine());

int count = 0, friend = 2, time = 0, time2 = 0, firstFriendCoord = 0, secondFriendCoord = 200, dogMeetCoord = 0;

while (distance > 10)
{
    if (friend == 1)
    {
        time = distanceBetween / (firstFriendSpeed + dogSpeed);
        friend = 2;
    }
    else
    {
        time = distanceBetween / (secondFriendSpeed + dogSpeed);
        friend = 1;
    }

    distanceBetween -= (firstFriendSpeed + secondFriendSpeed) * time;
    count++;
    while (distanceGraph >= step)
    {
        firstFriendCoord = (time2 * firstFriendSpeed) / step;
        secondFriendCoord = 200 - (time2 * secondFriendSpeed) / step;
        dogMeetCoord = (dogSpeed * (distance / (dogSpeed + secondFriendSpeed))) / step;
        distanceGraph -= (firstFriendSpeed + secondFriendSpeed) * 60;

        Console.Clear();
        if (friend == 2)
        {
            Console.SetCursorPosition(dogSpeed * time2 / step, 1);
            Console.WriteLine("@");
            if (secondFriendCoord >= dogMeetCoord)
            {
                friend = 1;
            }
            if (friend == 1)
            {
                Console.SetCursorPosition(dogSpeed * time2 / step, 1);
                Console.WriteLine("@");
            }

            Console.SetCursorPosition(firstFriendCoord, 1);
            Console.WriteLine("▓");

            Console.SetCursorPosition(secondFriendCoord, 1);
            Console.WriteLine("▓");

            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"Distance - {distanceBetween} meters");

            for (int i = 0; i < 200; i++)
            {
                Console.SetCursorPosition(i, 2);
                Console.WriteLine("-");
            }

            time2 += 60;
            await Task.Delay(500);
        }
    }
}
Console.Write($"\nThe dog ran {count} times.");