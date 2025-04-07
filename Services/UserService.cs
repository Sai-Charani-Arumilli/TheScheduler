using Microsoft.EntityFrameworkCore;
using Schedulerapp.DTOs;
using SchedulerApp.Data;
using SchedulerApp.Models;


public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;
    private readonly ApplicationDbContext _context;

    public UserService(IUserRepository userRepository, ApplicationDbContext context)
    {
        _userRepository = userRepository;
        _context = context;
    }

    public List<User> GetUsers(){
        return _context.UsersInApplication.ToList();
    }

    public List<Select2Result> SearchUsers(string query)
    {
        return _userRepository.SearchUsers(query);
    }
}