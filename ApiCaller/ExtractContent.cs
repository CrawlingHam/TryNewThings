using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace ApiCaller;

public class ExtractData
{
    public static async Task ExtractJsonData(HttpResponseMessage response)
    {
        await StringToJObject(response);
        
    }

    private static async Task StringToJObject(HttpResponseMessage response)
    {
        string content = await response.Content.ReadAsStringAsync();
        dynamic? contentObj = JsonConvert.DeserializeObject<dynamic>(content);
        if (contentObj is not null)
        {
            GetData.DetermineApiToCall(contentObj);
        }
        else
        {
            Console.WriteLine("Cannot operate with a nulled object.");
        }
    }
}