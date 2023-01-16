using BlazorIntro.Models;

using System.Net.Http.Json;

using static BlazorIntro.Pages.ToDo;
using static System.Net.WebRequestMethods;

namespace BlazorIntro.Services
{
    public class JsonPlaceholderApi:IApiService
    {
        private HttpClient _httpClient;

        public JsonPlaceholderApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public  Task<ToDoItem[]?> GetTodos()
        {
            return _httpClient.GetFromJsonAsync<ToDoItem[]?>("https://jsonplaceholder.typicode.com/todos");
        }
    }
}
