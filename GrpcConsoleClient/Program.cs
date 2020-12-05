using Grpc.Net.Client;
using GrpcServicePractise;
using System;
using System.Threading.Tasks;
using static GrpcServicePractise.Greeter;
using static System.Console;

namespace GrpcConsoleClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new GreeterClient(channel);

            var request = new HelloRequest
            {
                Name = "Joseph"
            };
            var response = await client.SayHelloAsync(request);
            WriteLine(response.Message);
            var yaResponse = await client.SayYaAsync(request);
            WriteLine(yaResponse.Message);
            ReadKey();
        }
    }
}
