using AsistenciasCrud.Shared;
namespace Asistencias2Crud.Client.Services
{
    public interface IUsuarioService
    {
        Task<List<UsuariosIN>> Lista();
        Task<UsuariosIN> Buscar(int id);
        Task<int> Guardar(UsuariosIN usuario);
        Task<bool> Editar(int id, UsuariosIN usuario);
        Task<bool> Eliminar(int id);
    }
}
