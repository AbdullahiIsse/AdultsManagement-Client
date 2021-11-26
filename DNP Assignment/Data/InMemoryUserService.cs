using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;


namespace DNP_Assignment.Data
{
    public class InMemoryUserService : IUserService
    {
        public async Task<User> ValidateUser(string userName, string Password)
        {
            using HttpClient httpClient = new HttpClient();

            var httpResponseMessage =
                await httpClient.GetAsync($"https://localhost:5009/User?username={userName}&password={Password}");
            
            if (!httpResponseMessage.IsSuccessStatusCode)
            {
                throw new Exception("User not Found");
            }
            

            var readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync();


            User user = JsonSerializer.Deserialize<User>(readAsStringAsync, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return user;
        }
    }
}