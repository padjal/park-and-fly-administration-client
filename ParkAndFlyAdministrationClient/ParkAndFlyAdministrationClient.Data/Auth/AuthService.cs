using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text;
using Blazored.SessionStorage;
using ParkAndFlyAdministrationClient.Client.Data.Requests;
using ParkAndFlyAdministrationClient.Client.Data.Response;
using ParkAndFlyAdministrationClient.Client.Auth;
using System.Net.Http;

namespace ParkAndFlyAdministrationClient.Data.Auth
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ISessionStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ISessionStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        /*public async Task<RegisterResult> Register(RegisterModel registerModel)
        {
            var result = await _httpClient.PostJsonAsync<RegisterResult>("api/accounts", registerModel);

            return result;
        }*/

        public async Task<LoginResponse> Login(LoginRequest loginModel)
        {
            try
            {
                var loginAsJson = JsonSerializer.Serialize(loginModel);
                var response = await _httpClient.PostAsync("login", new StringContent(loginAsJson, Encoding.UTF8, "application/json"));
                var loginResult = JsonSerializer.Deserialize<LoginResponse>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                if (!response.IsSuccessStatusCode)
                {
                    return loginResult;
                }

                await _localStorage.SetItemAsync("authToken", loginResult.AccessToken);
                await _localStorage.SetItemAsync("refreshToken", loginResult.RefreshToken);
                ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(loginModel.Email);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", loginResult.AccessToken);

                return loginResult;

            }
            catch (Exception ex)
            {

            }
            
            return new LoginResponse();
        }

        public async Task Logout()
        {
            await _localStorage.RemoveItemAsync("authToken");
            ((ApiAuthenticationStateProvider)_authenticationStateProvider).MarkUserAsLoggedOut();
            _httpClient.DefaultRequestHeaders.Authorization = null;
        }
    }
}
