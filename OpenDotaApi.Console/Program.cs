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

            foreach (var item in res)
            {
                System.Console.WriteLine($"{item.Tag}");
            }
        }
    }
}
