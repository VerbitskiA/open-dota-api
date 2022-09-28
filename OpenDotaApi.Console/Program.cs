using OpenDotaApi.Console.Models;
using OpenDotaApi.Console.Services;

namespace OpenDotaApi.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            OpenDotaApiService dotaApiService = new OpenDotaApiService();
            
            //Team[]? res = dotaApiService.GetTop10Teams();

            string? str;
            do
            {
                System.Console.WriteLine("1.Узнать текущее кол-во: ");
                System.Console.WriteLine("2.Вывод статистики");
                System.Console.WriteLine("3.Выход");
                System.Console.Write("Выберите пункт меню: ");
                str = System.Console.ReadLine();
                
                switch (str)
                {
                    case "1":
                        System.Console.WriteLine("===========================");
                        System.Console.WriteLine("Текущее значение количества выводимых данных:");
                        System.Console.WriteLine("===========================");
                        break;
                    case "2":
                        System.Console.WriteLine("Сколько команд показать?");

                        int n = int.Parse(System.Console.ReadLine());

                        Team[]? res = dotaApiService.GetTopNTeams(n);


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

