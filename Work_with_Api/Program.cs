using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class Request
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }

        [JsonPropertyName("results")]
        public List<Movie> Results { get; set; }

        [JsonPropertyName("total_pages")]
        public int TotalPages { get; set; }

        [JsonPropertyName("total_results")]
        public int TotalResults { get; set; }
    }

    public class Movie
    {
        [JsonPropertyName("adult")]
        public bool Adult { get; set; }

        [JsonPropertyName("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonPropertyName("genre_ids")]
        public List<int> GenreIds { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonPropertyName("original_name")]
        public string OriginalName { get; set; }

        [JsonPropertyName("original_title")]
        public string OriginalTitle { get; set; }

        [JsonPropertyName("overview")]
        public string Overview { get; set; }

        [JsonPropertyName("popularity")]
        public double Popularity { get; set; }

        [JsonPropertyName("poster_path")]
        public string PosterPath { get; set; }

        [JsonPropertyName("release_date")]
        public string ReleaseDate { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("video")]
        public bool Video { get; set; }

        [JsonPropertyName("vote_average")]
        public double VoteAverage { get; set; }

        [JsonPropertyName("vote_count")]
        public int VoteCount { get; set; }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string baseUrl = "https://api.themoviedb.org/3";
            string key = "9d005c81618cf4d45a9f6977b2d85774";
            string type = "movie";
            int num = 1;
            string json;
            WebClient webClient = new WebClient();


            do
            {
                Console.WriteLine("1 - Movie\n2 - Tv\n3 - Search Movie\n");

                int.TryParse(Console.ReadLine(), out int select);

                switch (select)
                {
                    case 1:
                        type = "movie";
                        json = webClient.DownloadString($"{baseUrl}/{type}/popular?api_key={key}&page={num}");

                        var request = JsonSerializer.Deserialize<Request>(json);

                        foreach (var item in request.Results)
                        {
                            Console.WriteLine(item.OriginalTitle);
                            Console.WriteLine(item.ReleaseDate);
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        type = "tv";
                        json = webClient.DownloadString($"{baseUrl}/{type}/popular?api_key={key}&page={num}");

                        request = JsonSerializer.Deserialize<Request>(json);

                        foreach (var item in request.Results)
                        {
                            Console.WriteLine(item.OriginalName);
                            Console.WriteLine(item.ReleaseDate);
                            Console.WriteLine();
                        }
                        break;
                    case 3:

                        Console.WriteLine("Please enter movie for searching : ");
                        string search = Console.ReadLine();
                        json = webClient.DownloadString($"{baseUrl}/search/{type}?api_key={key}&page={num}&query={search}");

                        request = JsonSerializer.Deserialize<Request>(json);

                        foreach (var item in request.Results)
                        {
                            Console.WriteLine(item.OriginalTitle);
                            Console.WriteLine(item.ReleaseDate);
                            Console.WriteLine();
                        }
                        break;
                    default:
                        break;
                }



            } while (true);




        }
    }






}