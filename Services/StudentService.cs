
namespace DhakaRegencyProject.Services;

public class StudentService : IStudentService
{
    private readonly ApplicationDBContext _context;

    public StudentService(ApplicationDBContext context)
    {
        _context = context;
    }
    public async Task<Student> CreateStudentAsync(Student newStudent)
    {
        newStudent.Id = Guid.NewGuid();
        _context.Students.Add(newStudent);
        await _context.SaveChangesAsync();
        return newStudent;
    }

    public async Task<List<Student>> GetAllStudentsAsync()
    {
        return await _context.Students.Include(s => s.Class).ToListAsync();
    }

    public async Task<Student> GetStudentByIdAsync(Guid id)
    {
        var student =  await _context.Students.Include(s => s.Class).FirstOrDefaultAsync(s => s.Id == id);
        if (student is null)
        {
            throw new Exception("Student Not Found");
        }
        return student;
    }

    public async Task UpdateStudentAsync(Student updatedStudent)
    {
        _context.Students.Update(updatedStudent);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudentAsync(Guid id)
    {
        var studentToDelete = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);
        if (studentToDelete != null)
        {
            _context.Students.Remove(studentToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
