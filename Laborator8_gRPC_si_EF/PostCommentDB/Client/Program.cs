using Grpc.Net.Client;
using GrpcService;
using System;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // The port number(5001) must match the port of the gRPC server.
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new PostG.PostGClient(channel);
            var reply = client.GetAllPosts(  new EmptyMsg { } );

            Console.WriteLine( reply.ToString());



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

    }
}
