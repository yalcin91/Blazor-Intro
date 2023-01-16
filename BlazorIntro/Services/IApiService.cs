using BlazorIntro.Models;

namespace BlazorIntro.Services
{
    public interface IApiService
    {
        Task<ToDoItem[]?> GetTodos();
    }
}
