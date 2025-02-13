using SchedulerApp.Data;
using SchedulerApp.Models;

public interface IUserService{
    List<User> GetUsers();
}

public class UserService: IUserService{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context){
        _context = context;
    }

    public List<User> GetUsers(){
        return _context.UsersInApplication.ToList();
    }
}