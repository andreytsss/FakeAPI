using System;

namespace FakeAPI
{
    class Program
    {
        private static MeetManager meetManager;
        static void Main(string[] args)
        {
            //создал нового менеджера встреч
            meetManager = new MeetManager();

            Console.Write("Введите имя встречи: ");
            string user_nameMeet = Console.ReadLine();

            Console.Write("Введите год встречи: ");
            int user_nameMeetYear = int.Parse(Console.ReadLine());

            Console.Write("Введите месяц встречи: ");
            int user_nameMeetMonth = int.Parse(Console.ReadLine());

            Console.Write("Введите день встречи: ");
            int user_nameMeetDay = int.Parse(Console.ReadLine());

            Console.Write("Введите час встречи: ");
            int user_nameMeetHour = int.Parse(Console.ReadLine());

            Console.Write("Введите минуту встречи: ");
            int user_nameMeetMinute = int.Parse(Console.ReadLine());

            DateTime user_meetTime = new DateTime(user_nameMeetYear, user_nameMeetMonth, user_nameMeetDay, user_nameMeetHour , user_nameMeetMinute , 0);
            meetManager.AddNewMeet(user_nameMeet, user_meetTime);

            Console.ReadKey();
        }
    }
}
