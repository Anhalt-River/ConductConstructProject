using System.Threading.Tasks;

namespace ConductingConstructionProjects.Data
{
    public interface IPersonStorageServices
    {
        Task SetAsync<T>(string key, Task item) where T : class;

        Task SetStringAsync(string key, string value);

        Task<T> GetAsync<T>(string key) where T : class;

        Task<string> GetStringAsync(string key);

        Task RemoveAsync(string key);
    }
}
