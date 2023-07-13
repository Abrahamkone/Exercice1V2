using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Mvc;

public class NewsController : Controller
{
    public async Task<ActionResult> Index()
    {
        string apiKey = "5d7d85b601f14a808539d4ccb73a2976";
        string apiUrl = $"https://newsapi.org/v2/top-headlines?country=us&apiKey={apiKey}";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            // Traitez les données de réponse et transmettez-les à la vue
            return View(responseBody);
        }
    }
}
