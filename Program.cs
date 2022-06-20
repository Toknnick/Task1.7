using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursOfwaiting = 0;
            int minutesOfWaiting = 0;
            int minutesInHour = 60;
            int timeOfReceipt = 10;
            int waitingTime;

            Console.WriteLine("Введите кол-во человек перед Вами в очереди");
            int numberOfPersons = int.Parse(Console.ReadLine());
            waitingTime = timeOfReceipt * numberOfPersons;

            if (waitingTime > minutesInHour)
            {
                hoursOfwaiting = waitingTime / minutesInHour;
                waitingTime -= hoursOfwaiting * minutesInHour;
                minutesOfWaiting = waitingTime;
                Console.WriteLine($"Вы должы отстоять в очереди {hoursOfwaiting} часов и {minutesOfWaiting} минут ");
            }
            else
            {
                Console.WriteLine($"Вы должы отстоять в очереди {waitingTime} минут ");
            }
        }
    }
}
