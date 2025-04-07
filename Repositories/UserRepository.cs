using Schedulerapp.DTOs;
using SchedulerApp.Data;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Select2Result> SearchUsers(string query)
    {
        return _context.UsersInApplication
            .Where(u => u.First_Name.Contains(query))
            .Select(u => new Select2Result
            {
                id = u.id.ToString(),
                text = u.First_Name
            })
            .Take(10)
            .ToList();
    }

}