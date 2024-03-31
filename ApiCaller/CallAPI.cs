namespace ApiCaller;

public class Call
{
    private static readonly HttpClient _client = new HttpClient(); 
    public async Task CatfactAPI(Uri URL)
    {
        await SendHttpRequest(URL);
    }

    private static async Task SendHttpRequest(Uri URL)
    {
        /*  Sends a GET Request and returns the response if the response code is 200,
            otherwise throw an HttpRequestException.  */
        try
        {
            HttpResponseMessage response = await _client.GetAsync(URL);
            if (response.IsSuccessStatusCode) // Handle successfull response
            {
                await ExtractData.ExtractJsonData(response);
            }
            else // Handle unsuccessfull response
            {
                Console.WriteLine($"{(int)response.StatusCode} Error. Resource {response.StatusCode}.");
            }
        }
        catch (HttpRequestException HttpError) // Handle exception
        {   
            Console.WriteLine($"Exception Encountered: {HttpError.Message}");
        }
    }
}
