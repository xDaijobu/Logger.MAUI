namespace Logger.MAUI.Utils;

public class LoggerUtils
{
    private static readonly HttpClient client;

    static LoggerUtils()
    {
        client = new HttpClient
        {
            Timeout = TimeSpan.FromSeconds(10) // Optional: Set a timeout for the request
        };
    }
    
    public static async Task<bool> IsInternetConnectionAvailable()
    {
        try
        {
            HttpResponseMessage response = await client.GetAsync("http://www.google.com");
            return response.IsSuccessStatusCode;
        }
        catch (HttpRequestException)
        {
            return false;
        }
        catch (TaskCanceledException)
        {
            return false;
        }
    }
}