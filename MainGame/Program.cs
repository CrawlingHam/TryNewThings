using ApiCaller;

namespace MainGame
{
    class Program
    {
        static async Task Main()
        {
            Uri URL;
            //URL = new Uri("https://catfact.ninja/fact");
            URL = new("https://official-joke-api.appspot.com/random_joke"); 

            Call call = new();
            await call.CatfactAPI(URL);
        }
    }
}
 