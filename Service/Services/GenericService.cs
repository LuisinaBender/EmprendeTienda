using Service.Class;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        protected readonly HttpClient client;
        protected readonly JsonSerializerOptions options;
        protected readonly string _endpoint;

        public GenericService(HttpClient httpClient)
        {
            client = httpClient;
            options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _endpoint = ApiEndpoints.GetEndpoint(typeof(T).Name); // debe devolver por ejemplo: "clientes"
        }

        public async Task<List<T>> GetAllAsync()
        {
            var response = await client.GetAsync(_endpoint);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Status: {response.StatusCode}, Content: {content}");
            }
            return JsonSerializer.Deserialize<List<T>>(content, options);
        }

        public async Task<T> GetByIdAsync(int id)
        {
            var response = await client.GetAsync($"{_endpoint}/{id}");
            var content = await response.Content.ReadAsStreamAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response?.ToString());
            }
            return JsonSerializer.Deserialize<T>(content, options);
        }

        public async Task<T> AddAsync(T entity)
        {
            var response = await client.PostAsJsonAsync(_endpoint, entity);
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException($"Error al hacer la solicitud: {response.StatusCode} - {content}");
            }
            return JsonSerializer.Deserialize<T>(content, options);
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException(nameof(entity), "Entity cannot be null");
            }

            var idProperty = entity.GetType().GetProperty("Id"); // <--- Cambiado de "ID" a "Id"
            if (idProperty == null)
            {
                throw new InvalidOperationException("La entidad no tiene una propiedad 'Id'");
            }

            var idValue = idProperty.GetValue(entity);
            if (idValue == null || (int)idValue == 0)
            {
                throw new InvalidOperationException("El valor de la propiedad 'Id' no puede ser null o 0");
            }

            var response = await client.PutAsJsonAsync($"{_endpoint}/{idValue}", entity);
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response?.ToString());
            }
        }

        public async Task DeleteAsync(int id)
        {
            var response = await client.DeleteAsync($"{_endpoint}/{id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(response.ToString());
            }
        }
    }
}
