using AsistenciasCrud.Shared;
namespace AsistenciasCrud.Client.Services
{
    public interface IUsuarioService
    {
        Task<List<UsuariosIN>> Lista();
        Task<UsuariosIN> Buscar(int id);
        Task<int> Guardar(UsuariosIN usuario);
        Task<int> Editar(UsuariosIN usuario);
        Task<bool> Eliminar(int id);
    }
}
