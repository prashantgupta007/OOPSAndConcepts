using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPSAndCore.Org
{
    public class Embibe
    {
        struct Struct
        {
            public int foo;
        }
        //public static int ClosestToZero(int[] ints)
        //{
        //    if (ints == null || ints.Length == 0)
        //    {
        //        retun 0;
        //    }

        //    var closest = 0;

        //    foreach (var number in ints)
        //    {
        //        if (number > 0 && number < closest)
        //        {
        //            closest = number;
        //        }
        //    }
        //    retrun closest;
        //}
        public static IEnumerable<string> Filter(List<string> strings)
        {
            //return strings.Sta("L");
            var res = from s in strings
                   where s.StartsWith("L")
                   orderby s
                   select s;

            return res;
        }

        public static string Sum(params string[] numbers)
        {
            float total = 0;

            foreach (string number in numbers)
            {
                total = total + float.Parse(number);
            }

            return total.ToString();
        }

        public static void Main1()
        {
            var fruit = new XElement( "fruit", "orange" );
            var bag1 = new XElement( "bag", fruit);
            var bag2 = new XElement( "bag", fruit);
            fruit.SetValue("apple");
            Console.WriteLine(bag2.Element("fruit").Value);


            //var d = new DateTime(0);
            //d.AddHours(2);
            //Console.WriteLine(d.Hour);


            //Console.WriteLine(Sum("-1.001", "1.01"));

            //var strings = new List<string>();
            //var filteredStrings = Filter(strings);

            //strings.Add("Gurt");
            //strings.Add("Lobster");
            //strings.Add("Litch");
            //strings.Add("Doe");

            //foreach (var str in filteredStrings)
            //{
            //    Console.WriteLine(str);
            //}

            //Struct struct1;
            //struct1.foo = 5;

            //Struct struct2 = struct1;
            //struct1.foo = 10;

            //Console.WriteLine(struct1.foo);


            //var sd = new SortedDictionary<int, int>();
            //sd[3] = 3;
            //sd[2] = 1;
            //sd[1] = 2;
            //foreach (var item in sd) {
            //    Console.WriteLine(item);
            //}
            //int i = 0;
            //Console.WriteLine(i++);
            Console.ReadLine();
            //List<int[]> a = new List<int[]>();
            //a.Add(new int[] { 1, 2 });
            //a.Add(new int[] { 1, 2, 3 });
            //a.Add(new int[] { 1, 2 });

            //getMovieTitles("don");
        }

        //static string[] getMovieTitles(string substr)
        static void getMovieTitles(string substr)
        {
            var apiAddress = $"movies/search/?Title={substr}&page=1";
            //var firstResponse = GetHTTPClientAsync<MovieResponse>(apiAddress);
            var firstResponse = MakeHTTPRequest<object>(HttpMethod.Get, apiAddress);

        }

        static async Task GetHTTPClientAsync<T>(string apiAddress)
        {
            var baseAddress = $"https://jsonmock.hackerrank.com/api/{apiAddress}";
            using (var client = new HttpClient())
            {
                using (var response = client.GetAsync(baseAddress).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var customerJsonString = await response.Content.ReadAsStringAsync();
                        var result = JsonConvert.DeserializeObject<Response<T>>(customerJsonString);
                    }
                    else
                    {
                        Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
                    }
                }
            }
        }

        private static readonly HttpClient Client = new HttpClient(new HttpClientHandler
        {
            UseCookies = false
        });

        private static async Task<Response<TResponse>> MakeHTTPRequest<TResponse>(HttpMethod method, string apiAddress)
        {
            var baseAddress = $"https://jsonmock.hackerrank.com/api/";

            var message = new HttpRequestMessage(method, $"{baseAddress}{apiAddress}");
            using (var client = new HttpClient())
            {
                var response = await client.SendAsync(message, HttpCompletionOption.ResponseContentRead);
                var content = await response.Content.ReadAsStringAsync();

                return new Response<TResponse>
                {
                    IsSuccess = response.IsSuccessStatusCode,
                    ResponseData = response.IsSuccessStatusCode ? JsonConvert.DeserializeObject<TResponse>(content) : default(TResponse),
                };
            }
        }

        public class Response<T>
        {
            public bool IsSuccess { get; set; }
            public T ResponseData { get; set; }
        }

        public class MovieResponse
        {
            public int page { get; set; }
            public int per_page { get; set; }
            public int total_pages { get; set; }
            public IEnumerable<Movie> data { get; set; }
        }

        public class Movie
        {
            public string Title { get; set; }
            public int Year { get; set; }
            public string imdbID { get; set; }
        }
    }
}
