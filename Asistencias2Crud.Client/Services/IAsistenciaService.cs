using AsistenciasCrud.Shared;
namespace Asistencias2Crud.Client.Services
{
    public interface IAsistenciaService
    {
        Task<List<AsistenciaIN>> Lista();
        Task<AsistenciaIN> Buscar(int id);
        Task<int> Guardar(AsistenciaIN asistencia);
        Task<int> Editar(int id, AsistenciaIN asistencia); 
        Task<bool> Eliminar(int id);
    }
}
