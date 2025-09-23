﻿using System.Net;
using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services;

public class UsersService : IUsersService
{
    private readonly HttpClient _httpClient;
    public UsersService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<User>> GetAllUsers()
    {
        var usersResponse = await _httpClient.GetAsync("https://example.com");
        if (usersResponse.StatusCode == HttpStatusCode.NotFound)
            return new List<User>();

        var responseContent = usersResponse.Content;
        var allUsers = await responseContent.ReadFromJsonAsync<List<User>>();
        return allUsers.ToList();
    }
}