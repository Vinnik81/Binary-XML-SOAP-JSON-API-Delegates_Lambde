using System;
using System.Net;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HomeWork_API
{

    public class Rootobject
    {
        public Coord coord { get; set; }
        public Weather[] weather { get; set; }
        public string _base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }

    public class Coord
    {
        public float lon { get; set; }
        public float lat { get; set; }
    }

    public class Main
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }

    public class Wind
    {
        public float speed { get; set; }
        public int deg { get; set; }
    }

    public class Clouds
    {
        public int all { get; set; }
    }

    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }

    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }





    class Program
    {
       
        static void Main(string[] args)
        {
            string baseUrl = "https://api.openweathermap.org/data/2.5/weather";
            string key = "04f2dc1734de1dc82dc7ae8b28e8f96d";
            Console.Write("Ведите названия города: ");
            string cityName = Console.ReadLine();
            Console.Write("Введите код страны: ");
            string countryCode = Console.ReadLine();
            WebClient webClient = new WebClient();
            var json = webClient.DownloadString($"{baseUrl}/?q={cityName},{countryCode}&appid={key}&units=metric");
            Console.WriteLine(json);
            Console.WriteLine("/--------------------------------------------------------------------------------------------------------------/");
            var rootobject = JsonSerializer.Deserialize<Rootobject>(json);
            Console.WriteLine(rootobject.name);
            Console.WriteLine("Координаты: ");
            Console.WriteLine(rootobject.coord.lat);
            Console.WriteLine(rootobject.coord.lon);
            Console.WriteLine("Погодные данные: ");
            foreach (var item in rootobject.weather)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.main);
                Console.WriteLine(item.description);
                Console.WriteLine(item.icon);
            }
            Console.WriteLine("Температура и Атмосферное давление: ");
            Console.WriteLine(rootobject.main.feels_like);
            Console.WriteLine(rootobject.main.temp);
            Console.WriteLine(rootobject.main.temp_max);
            Console.WriteLine(rootobject.main.temp_min);
            Console.WriteLine(rootobject.main.humidity);
            Console.WriteLine(rootobject.main.pressure);
            Console.WriteLine("Видимость: ");
            Console.WriteLine(rootobject.visibility);
            Console.WriteLine("Cкорость и Направление ветра: ");
            Console.WriteLine(rootobject.wind.speed);
            Console.WriteLine(rootobject.wind.deg);
            Console.WriteLine("Облачность: ");
            Console.WriteLine(rootobject.clouds.all);
            Console.WriteLine(rootobject.dt);
            Console.WriteLine("Системные данные: ");
            Console.WriteLine(rootobject.sys.type);
            Console.WriteLine(rootobject.sys.id);
            Console.WriteLine(rootobject.sys.country);
            Console.WriteLine(rootobject.sys.sunrise);
            Console.WriteLine(rootobject.sys.sunset);
            Console.WriteLine(rootobject.timezone);
            Console.WriteLine(rootobject.cod);
        }
    }
}

