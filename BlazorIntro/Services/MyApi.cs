using BlazorIntro.Models;

using System.Net.Http.Json;

namespace BlazorIntro.Services
{
    public class MyApi : IApiService
    {
        private HttpClient _httpClient;

        public MyApi(HttpClient httpClient) => _httpClient = httpClient;

        public Task<ToDoItem[]?> GetTodos()
        {
            return _httpClient.GetFromJsonAsync<ToDoItem[]?>("https://jsonplaceholder.typicode.com/todos");
        }
    }
}
