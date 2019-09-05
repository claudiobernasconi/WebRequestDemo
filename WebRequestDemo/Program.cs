using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static async Task Main(string[] args)
        {
            #region Example 1
            var httpClient = HttpClientFactory.Create();

            var url = "https://jsonplaceholder.typicode.com/todos/1";
            var data = await httpClient.GetStringAsync(url);

            Console.WriteLine(data);
            #endregion

            #region Example 2
            //var httpClient = HttpClientFactory.Create();

            //var url = "https://jsonplaceholder.typicode.com/todos/1";
            //HttpResponseMessage httpResponseMessage =
            //await httpClient.GetAsync(url);
            //if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            //{
            //    var content = httpResponseMessage.Content;
            //    var data = await content.ReadAsStringAsync();
            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine($"Error: " + httpResponseMessage.StatusCode);
            //}
            #endregion

            #region Example 3
            //var httpClient = HttpClientFactory.Create();

            //var url = "https://jsonplaceholder.typicode.com/todos/1";
            //HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);
            //if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
            //{
            //    var content = httpResponseMessage.Content;
            //    var data = await content.ReadAsAsync<Data>();

            //    Console.WriteLine(data);
            //}
            //else
            //{
            //    Console.WriteLine($"Error: " + httpResponseMessage.StatusCode);
            //}
            #endregion
        }
    }

    class Data
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

        public override string ToString()
        {
            return $"{UserId}, {Id}, {Title}, {Completed}";
        }
    }
}
