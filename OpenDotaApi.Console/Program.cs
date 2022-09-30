using OpenDotaApi.Console.Models;
using OpenDotaApi.Console.Services;

namespace OpenDotaApi.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            OpenDotaApiService dotaApiService = new OpenDotaApiService();

            string? menu;
            do
            {
                System.Console.WriteLine("1.Узнать текущее кол-во: ");
                System.Console.WriteLine("2.Вывод статистики");
                System.Console.WriteLine("3.Вывод статы по героям");
                System.Console.WriteLine("4.Абоба");
                System.Console.Write("Выберите пункт меню: ");
                menu = System.Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        System.Console.WriteLine("===========================");
                        System.Console.WriteLine("Текущее значение количества выводимых данных:");
                        System.Console.WriteLine("===========================");
                        break;
                    case "2":
                        System.Console.WriteLine("Сколько команд показать?");

                        int n = int.Parse(System.Console.ReadLine());

                        System.Console.WriteLine("По какому ключу сортировать?");
                        System.Console.WriteLine("1. по убыванию(рейтинг)");
                        System.Console.WriteLine("2. по возрастанию(рейтинг)");

                        string key = System.Console.ReadLine();

                        //TODO: по возрастанию или по убыванию

                        Team[]? res = dotaApiService.GetTopNTeams(n);

                        res = dotaApiService.SortArray(res, key, false);
                        switch (key)
                        {
                            case "1":
                                // шейкерная по убыванию

                                for (int i = 0; i < res.Length / 2; i++)
                                {
                                    for (int j = i; j < res.Length - i - 1; j++)
                                    {
                                        if (res[j].Rating > res[j + 1].Rating)
                                        {
                                            Team temp = res[j];
                                            res[j] = res[j + 1];
                                            res[j + 1] = temp;
                                        }
                                    }

                                    for (int j = res.Length - 2 - i; j > i; j--)
                                    {
                                        if (res[j - 1].Rating > res[j].Rating)
                                        {
                                            Team temp = res[j];
                                            res[j] = res[j - 1];
                                            res[j - 1] = temp;
                                        }
                                    }
                                }
                                break;
                            case "2":
                                //сортировка пузырьком по возрастанию
                                for (int i = 0; i < res.Length / 2; i++)
                                {
                                    for (int j = i; j < res.Length - i - 1; j++)
                                    {
                                        if (res[j].Wins > res[j + 1].Rating)
                                        {
                                            Team temp = res[j];
                                            res[j] = res[j + 1];
                                            res[j + 1] = temp;
                                        }
                                    }

                                    for (int j = res.Length - 2 - i; j > i; j--)
                                    {
                                        if (res[j - 1].Wins > res[j].Rating)
                                        {
                                            Team temp = res[j];
                                            res[j] = res[j - 1];
                                            res[j - 1] = temp;
                                        }
                                    }
                                }
                                break;

                            default:
                                System.Console.WriteLine("Неверный ключ aboba");
                                break;


                        }


                        System.Console.WriteLine("===========================");
                        System.Console.WriteLine(String.Format("{0,24}{1, 11}\t{2,8}\t{3,8}\t{4,8}\t{5,15}",
                                        "Name",
                                        "TAG",
                                        "Rating",
                                        "Wins",
                                        "Losses",
                                        "Last Match Time"));
                        System.Console.WriteLine("------------------------------------------------------------------------------");

                        foreach (var item in res)
                        {
                            System.Console.WriteLine(item.ToString());
                        }

                        System.Console.WriteLine("===========================");
                        break;

                    case "3":

                        System.Console.WriteLine("Сколько надо вывести персанажиков из Dota 2?");
                        int h = int.Parse(System.Console.ReadLine());
                        HeroInfo[] aboba = dotaApiService.GetTop10Heroes(h);
                        System.Console.WriteLine("===========================");
                        System.Console.WriteLine(String.Format("{0,24}{1, 11}\t{2,8}\t{3,8}",
                                        "ID",
                                        "NAME",
                                        "NormalName",
                                        "Roles"));
                        System.Console.WriteLine("------------------------------------------------------------------------------");

                        foreach (var item in aboba)
                        {
                            System.Console.WriteLine(item.ToString());
                        }

                        System.Console.WriteLine("===========================");
                        break;

                    case "4":
                        break;

                    default:
                        System.Console.WriteLine("===========================");
                        System.Console.WriteLine("Неверный пункт меню");
                        System.Console.WriteLine("===========================");
                        break;

                }
            }
            while (menu != "4");
        }
    }
}

