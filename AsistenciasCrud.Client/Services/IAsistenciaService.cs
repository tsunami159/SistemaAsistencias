using AsistenciasCrud.Shared;
namespace AsistenciasCrud.Client.Services
{
    public interface IAsistenciaService
    {
        Task<List<AsistenciaIN>> Lista();
        Task<AsistenciaIN> Buscar(int id);
        Task<int> Guardar(AsistenciaIN asistencia);
        Task<int> Editar(AsistenciaIN asistencia);
        Task<bool> Eliminar(int id);
    }
}
