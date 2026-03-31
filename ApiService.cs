using System.Net.Http;
using System.Threading.Tasks;

public static class ApiService
{
    private static readonly HttpClient client = new HttpClient();
    private static readonly string baseUrl = "http://127.0.0.1:5000";

    public static async Task<string> GetAsync(string endpoint)
    {
        var response = await client.GetAsync(baseUrl + endpoint);
        return await response.Content.ReadAsStringAsync();
    }

    public static async Task<string> PostAsync(string endpoint, HttpContent content)
    {
        var response = await client.PostAsync(baseUrl + endpoint, content);
        return await response.Content.ReadAsStringAsync();
    }
}
