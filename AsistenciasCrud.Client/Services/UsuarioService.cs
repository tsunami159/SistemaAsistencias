using System.Net.Http.Json;
using AsistenciasCrud.Shared;

namespace AsistenciasCrud.Client.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly HttpClient _httpClient;

        public UsuarioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<UsuariosIN>> Lista()
        {
            return await _httpClient.GetFromJsonAsync<List<UsuariosIN>>("api/Usuario/Lista");
        }

        public async Task<UsuariosIN> Buscar(int id)
        {
            return await _httpClient.GetFromJsonAsync<UsuariosIN>($"api/Usuario/Buscar/{id}");
        }

        public async Task<int> Guardar(UsuariosIN usuario)
        {
            var response = await _httpClient.PostAsJsonAsync("api/Usuario/Guardar", usuario);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<int> Editar(UsuariosIN usuario)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/Usuario/Editar/{usuario.IdUsuario}", usuario);
            return await response.Content.ReadFromJsonAsync<int>();
        }

        public async Task<bool> Eliminar(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/Usuario/Eliminar/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
