using Full.Shared;
using System.Net.Http.Json;

namespace Full.Client.Service
{
    public class ApiServices
    {
        public HttpClient _httpClient;

        public ApiServices(HttpClient httpClient) => _httpClient = httpClient;


        public async Task<List<Course>> GetAllCourses()
        {
            var result = await _httpClient.GetFromJsonAsync<List<Course>>("api/Course");
            return result;
        }
    }
}
