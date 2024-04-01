namespace DhakaRegencyProject.Services;

public class ClassService : IClassService
{
    private readonly ApplicationDBContext _context;

    public ClassService(ApplicationDBContext context)
    {
        _context = context;
    }
    public async Task<Class> CreateClassAsync(Class newClass)
    {
        _context.Classes.Add(newClass);
        await _context.SaveChangesAsync();
        return newClass;
    }

    public async Task<List<Class>> GetAllClassesAsync()
    {
        return await _context.Classes.ToListAsync();
    }

    public async Task<Class> GetClassByIdAsync(int id)
    {
        var existingclass = await _context.Classes.FirstOrDefaultAsync(c => c.Id == id);
        if (existingclass is null)
        {
            throw new Exception("Class Not Found");
        }
        return existingclass;
    }

    public async Task UpdateClassAsync(Class updatedClass)
    {
        updatedClass.ModificationDate = DateTime.Now;
        _context.Classes.Update(updatedClass);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteClassAsync(int id)
    {
        var classToDelete = await _context.Classes.FirstOrDefaultAsync(c => c.Id == id);
        if (classToDelete != null)
        {
            _context.Classes.Remove(classToDelete);
            await _context.SaveChangesAsync();
        }
    }
}
