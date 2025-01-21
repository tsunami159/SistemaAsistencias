using System.Net.Http.Json;
using AsistenciasCrud.Shared;

namespace AsistenciasCrud.Client.Services
{
    public class AsistenciaService : IAsistenciaService
    {
        private readonly HttpClient _httpClient;

        public AsistenciaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AsistenciaIN>> Lista()
        {
            return await _httpClient.GetFromJsonAsync<List<AsistenciaIN>>("api/Asistencia/Lista");
        }

        public async Task<AsistenciaIN> Buscar(int id)
        {
            return await _httpClient.GetFromJsonAsync<AsistenciaIN>($"api/Asistencia/Buscar/{id}");
        }

        public async Task<int> Guardar(AsistenciaIN asistencia)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Asistencia/Guardar", asistencia);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<int> Editar(AsistenciaIN asistencia)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Asistencia/Editar/{asistencia.IdAsistencia}", asistencia);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<bool> Eliminar(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Asistencia/Eliminar/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
