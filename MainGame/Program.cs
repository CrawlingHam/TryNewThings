using ApiCaller;

namespace MainGame
{
    class Program
    {
        static async Task Main()
        {
            Uri? URL = UserInput();
            if (URL is not null)
            {
                Call call = new();
                await call.CatfactAPI(URL);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
        private static Uri? UserInput()
        {
            /* Gets prompt from user and returns it. */
            Console.WriteLine("what would you like to do?");
            Console.WriteLine(@"
                        1. Get a random fact
                        2. Get a random joke
            : ");
            string? Input = Console.ReadLine();
            if (Input is not null)
            {
                if (Input == "1")
                {
                    return new Uri("https://catfact.ninja/fact");
                }
                else if (Input == "2")
                {
                    return new Uri("https://official-joke-api.appspot.com/random_joke");
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
 