using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using Blazored.SessionStorage;
using ParkAndFlyAdministrationClient.Client.Data.Response;
using ParkAndFlyAdministrationClient.Client.Data.Requests;

namespace ParkAndFlyAdministrationClient.Data.Auth
{
    public interface IAuthService
    {
        //public async Task<RegisterResult> Register(RegisterModel registerModel){}

        public Task<LoginResponse> Login(LoginRequest loginModel);

        public Task Logout();
    }
}
