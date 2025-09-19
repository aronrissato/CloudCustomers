using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services;

public interface IUsersService
{
    Task<List<User>> GetAllUsers();
}