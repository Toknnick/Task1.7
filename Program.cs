using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursOfwaiting = 0;
            int minutesOfWaiting = 0;
            int timeOfReceipt = 10;
            int waitingTime;

            Console.WriteLine("Введите кол-во человек перед Вами в очереди");
            int numberOfPersons = int.Parse(Console.ReadLine());
            waitingTime = timeOfReceipt * numberOfPersons;

            if (waitingTime >= 60)
            {
                hoursOfwaiting = waitingTime / 60;
                waitingTime -= hoursOfwaiting * 60;
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
