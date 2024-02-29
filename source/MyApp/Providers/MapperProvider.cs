
using System.Collections;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace MyApp.Providers
{
    public class MapperProvider
    {
        private static readonly Lazy<MapperProvider> _instance = _instance ??= new Lazy<MapperProvider>(() => new MapperProvider());

        public static MapperProvider Instance => _instance.Value;

        public T Map<T>(object dto)
        {
            try
            {
                var json = JsonSerializer.Serialize(dto);
                return JsonSerializer.Deserialize<T>(json) ?? Activator.CreateInstance<T>();
            }
            catch (Exception e)
            {
                return Activator.CreateInstance<T>();
            }
        }

        public ObservableCollection<T> MapCollection<T>(IEnumerable dto)
        {
            try
            {
                var json = JsonSerializer.Serialize(dto);
                return JsonSerializer.Deserialize<ObservableCollection<T>>(json) ?? new ObservableCollection<T>();
            }
            catch (Exception e)
            {
                return new ObservableCollection<T>();
            }
        }

        public List<T> MapList<T>(IEnumerable dto)
        {
            try
            {
                var json = JsonSerializer.Serialize(dto);
                return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
            }
            catch (Exception e)
            {
                return new List<T>();
            }
        }

    }
}
