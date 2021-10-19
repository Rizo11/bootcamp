using System;
using System.Text.Json;
using System.Threading.Tasks;
using lesson10.Dto.PrayerTime;
using lesson10.Dto.User;
using lesson10.Services;

namespace lesson10
{
    class Program
    {
        private static string usersApi = "https://randomuser.me/api/";
        private static string prayerTimeApi = $"http://api.aladhan.com/v1/timingsByCity?city=Tashkent&country=Uzbekistan&method=8";

        private static void etid(string country, string city)
        {
            prayerTimeApi = $"http://api.aladhan.com/v1/timingsByCity?city={city}&country={country}&method=8";
        }

        static async Task Main(string[] args)
        {
            System.Console.WriteLine("City: ");
            var city =  Console.ReadLine();
            System.Console.WriteLine("Country: ");
            var country = Console.ReadLine();
            etid(country, city);

            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<PrayerTime>(prayerTimeApi);

            if(result.IsSuccess)
            {
                var settings = new JsonSerializerOptions()
                {
                    WriteIndented = true
                };

                // var json = JsonSerializer.Serialize(result.Data, settings);
                // string fajr = json.Substring(79, 5);
                // string sunrise = json.Substring(105, 5);

                // for(int i = 79; i<= 87; i++)
                // {
                //     System.Console.WriteLine(json.Substring(i, ));
                // }
                // System.Console.WriteLine($">>{fajr}<<");
                // System.Console.WriteLine(json.Substring(122, 5));
                // Console.WriteLine($"{json.Substring(64, 220)}");

                var json = JsonSerializer.Serialize(result.Data.Data.Meta.Timezone, settings).Replace("\"", "");
                Console.WriteLine($"{json} dagi namoz vaqtlari");
                var date = JsonSerializer.Serialize(result.Data.Data.Date.Gregorian.Date, settings).Replace("\"", "");
                Console.WriteLine($"Sana: {date}\n");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Fajr, settings).Replace("\"", "");
                Console.WriteLine($"Bomdod vaqti:         {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Sunrise, settings).Replace("\"", "");
                Console.WriteLine($"Quyosh chiqish vaqti: {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Dhuhr, settings).Replace("\"", "");
                Console.WriteLine($"Peshin vaqti:         {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Asr, settings).Replace("\"", "");
                Console.WriteLine($"Asr vaqti:            {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Sunset, settings).Replace("\"", "");
                Console.WriteLine($"Quyosh botish vaqti:  {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Maghrib, settings).Replace("\"", "");
                Console.WriteLine($"Shom vaqti:           {json}");
                json = JsonSerializer.Serialize(result.Data.Data.Timings.Isha, settings).Replace("\"", "");
                Console.WriteLine($"Xufton vaqti:         {json}");

            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }
            
        }
        static async Task Main_user(string[] args)
        {
            var httpService = new HttpClientService();
            var result = await httpService.GetObjectAsync<User>(usersApi);

            if(result.IsSuccess)
            {
                Console.WriteLine($"{result.Data.Results[0].Name.First}");
            }
            else
            {
                Console.WriteLine($"{result.ErrorMessage}");
            }
            
        }
    }
}
