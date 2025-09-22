using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixtures;

public static class UsersFixture
{
    public static List<User> GetTestUsers() => new()
    {
        new User
        {
            Name = "TESTE1",
            Email = "email1@email.com",
            Address = new Address
            {
                City = "Curitiba",
                Street = "Presidente Taunay",
                ZipCode = "80430000"
            }
        },
        new User
        {
            Name = "TESTE2",
            Email = "email2@email.com",
            Address = new Address
            {
                City = "Curitiba",
                Street = "Padre Agostinho",
                ZipCode = "80430000"
            }
        }
    };
}