using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace ApiCaller;

public class GetData
{
    public static void DetermineApiToCall(dynamic contentObj)
    {
        /*  The keys inside JObject contentObj signifies which
            API was called. By checking which key is inside contentObj,
            the appropriate filters can be called. */

        if (contentObj.ContainsKey("fact")) // Catfact API has a 'fact' key
        {
            GetFact(contentObj);
        }
        else if (contentObj.ContainsKey("setup") && contentObj.ContainsKey("punchline")) // Joke API has 'setup' and 'punchline' keys
        {
            GetJoke(contentObj);
        }
        else // Handle case: key(s) not found
        {
            Console.WriteLine("Key not found.");
        }
    }
    public static void GetFact(dynamic contentObj)
    {
        var fact = contentObj.fact;
        var length = contentObj.length;

        Console.WriteLine(contentObj); // See unfiltered object
        Console.WriteLine(fact);
        Console.WriteLine(length);
    }
    public static void GetJoke(dynamic contentObj)
    {
        var setup = contentObj.setup;
        var punchline = contentObj.punchline;

        Console.WriteLine(contentObj); // See unfiltered object
        Console.WriteLine(setup);
        Console.WriteLine(punchline);
    }
}