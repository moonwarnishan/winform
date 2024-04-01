namespace DhakaRegencyProject.Interfaces;

public interface IClassService
{
    Task<Class> CreateClassAsync(Class newClass);
    Task<List<Class>> GetAllClassesAsync();
    Task<Class> GetClassByIdAsync(int id);
    Task UpdateClassAsync(Class updatedClass);
    Task DeleteClassAsync(int id);

}
