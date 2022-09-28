using OpenDotaApi.Console.Models;
using OpenDotaApi.Console.Services;

namespace OpenDotaApi.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TODO:
            //1. Класс, описывающий команду +
            //2. Класс, который будет производить http-запросы на opendotaapi +-
            //3. Класс, который взаимодействует с пользователем: спрашиваем имя команды, выводит на консоль данные, меню.

            //4. Класс, который считает статистику и т.д.
            OpenDotaApiService dotaApiService = new OpenDotaApiService();
            Team[]? res = dotaApiService.GetTop10Teams();
            string? str;
            do
            {
                System.Console.WriteLine("1.Узнать текущее кол-во: ");
                System.Console.WriteLine("2.Вывод статистики");
                System.Console.WriteLine("3.Выход");
                System.Console.Write("Выберите пункт меню: ");
                str = System.Console.ReadLine();
                int N = 10;
                switch (str)
                {
                    case "1":
                        System.Console.WriteLine("===========================");
                        System.Console.WriteLine("Текущее значение количества выводимых данных: " + N);
                        System.Console.WriteLine("===========================");
                        break;
                    case "2":
                        int i = 1;
                        System.Console.WriteLine("===========================");
                        System.Console.WriteLine(String.Format("{0, 11}\t{1,8}\t{2,8}\t{3,8}\t{4,15}",
                                        "TAG",
                                        "Rating",
                                        "Wins",
                                        "Losses",
                                        "Last Match Time"));
                        System.Console.WriteLine("------------------------------------------------------------------------------");
                        foreach (var item in res)
                        {
                            string s = String.Format("{0, 11}\t{1,8}\t{2,8}\t{3,8}\t{4,15}",
                                        item.Tag,
                                        item.Rating,
                                        item.Wins,
                                        item.Losses,
                                        item.Last_Match_Time);

                            System.Console.WriteLine(s);
                            i++;
                            if (i > N)
                            {
                                break;
                            }
                        }
                        System.Console.WriteLine("===========================");
                        break;

                    case "3":
                        break;
                    default:
                        System.Console.WriteLine("===========================");
                        System.Console.WriteLine("Неверный пункт меню");
                        System.Console.WriteLine("===========================");
                        break;
                }
            }
            while (str != "3");

        }
    }
}

