using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services;

public class UsersService : IUsersService
{
    public UsersService() { }

    public Task<List<User>> GetAllUsers()
    {
        throw new NotImplementedException();
    }
}