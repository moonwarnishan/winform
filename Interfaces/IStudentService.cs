namespace DhakaRegencyProject.Interfaces;

public interface IStudentService
{
    Task<Student> CreateStudentAsync(Student newStudent);
    Task<List<Student>> GetAllStudentsAsync();
    Task<Student> GetStudentByIdAsync(Guid id);
    Task UpdateStudentAsync(Student updatedStudent);
    Task DeleteStudentAsync(Guid id);
}
