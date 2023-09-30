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
            var courses = await _httpClient.GetFromJsonAsync<List<Course>>("api/Course");
            return courses;
        }

        public async Task<List<Teacher>> GetAllTeachers()
        {
            var teachers = await _httpClient.GetFromJsonAsync<List<Teacher>>("api/Teacher");
            return teachers;
        }
    }
}
