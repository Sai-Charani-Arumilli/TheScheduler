using Schedulerapp.DTOs;
using SchedulerApp.Models;

public interface IUserService{
    List<User> GetUsers();
    List<Select2Result> SearchUsers(string query);
}
