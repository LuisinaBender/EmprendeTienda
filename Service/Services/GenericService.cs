using Service.Class;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Service.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        protected readonly HttpClient _httpClient;
        protected readonly JsonSerializerOptions _jsonOptions;
        protected readonly string _endpoint;

        public GenericService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _jsonOptions = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                WriteIndented = true,
                ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve
            };
            _endpoint = ApiEndpoints.GetEndpoint(typeof(T).Name);
        }

        public async Task<List<T>> GetAllAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync(_endpoint);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<T>>(_jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                throw new ApplicationException($"Error al obtener {typeof(T).Name}: {ex.Message}", ex);
            }
        }

        public async Task<T> GetByIdAsync(int id)
        {
            try
            {
                var response = await _httpClient.GetAsync($"{_endpoint}/{id}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                throw new ApplicationException($"Error al obtener {typeof(T).Name} con ID {id}: {ex.Message}", ex);
            }
        }

        public async Task<T> AddAsync(T entity)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync(_endpoint, entity, _jsonOptions);
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
            }
            catch (HttpRequestException ex)
            {
                var errorContent = await ex.GetResponseContentAsync();
                throw new ApplicationException($"Error al agregar {typeof(T).Name}: {errorContent ?? ex.Message}", ex);
            }
        }

        public async Task UpdateAsync(T entity)
        {
            try
            {
                var id = GetEntityId(entity);
                var response = await _httpClient.PutAsJsonAsync($"{_endpoint}/{id}", entity, _jsonOptions);
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                var errorContent = await ex.GetResponseContentAsync();
                throw new ApplicationException($"Error al actualizar {typeof(T).Name}: {errorContent ?? ex.Message}", ex);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                var response = await _httpClient.DeleteAsync($"{_endpoint}/{id}");
                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                throw new ApplicationException($"Error al eliminar {typeof(T).Name} con ID {id}: {ex.Message}", ex);
            }
        }

        private int GetEntityId(T entity)
        {
            var idProperty = entity.GetType().GetProperty("Id") ??
                             entity.GetType().GetProperty("ID");

            if (idProperty == null)
                throw new InvalidOperationException($"La entidad {typeof(T).Name} no tiene propiedad Id");

            var idValue = idProperty.GetValue(entity) as int?;

            if (!idValue.HasValue || idValue.Value == 0)
                throw new InvalidOperationException("ID no puede ser nulo o cero");

            return idValue.Value;
        }
    }

    public static class HttpRequestExceptionExtensions
    {
        public static async Task<string> GetResponseContentAsync(this HttpRequestException ex)
        {
            if (ex.Data.Contains("ResponseContent"))
                return ex.Data["ResponseContent"] as string;

            return null;
        }
    }
}