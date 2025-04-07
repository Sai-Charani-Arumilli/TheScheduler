using Schedulerapp.DTOs;

public interface IUserRepository
{
    List<Select2Result> SearchUsers(string query);
}
