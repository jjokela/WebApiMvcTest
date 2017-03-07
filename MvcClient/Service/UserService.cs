using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Model;
using System.Net;

namespace MvcClient.Service
{
    public class UserService
    {
        private string uri = "http://localhost:11057/api/User";

        public async Task<Uri> Create(User user)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync(uri, user);
                response.EnsureSuccessStatusCode();

                return response.Headers.Location;
            }
        }

        public async Task<List<User>> GetAll()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                List<User> users = null;
                HttpResponseMessage response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    users = await response.Content.ReadAsAsync<List<User>>();
                }
                return users;
            }
        }

        public async Task<User> Details(int userId)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                User user = null;
                HttpResponseMessage response = await httpClient.GetAsync(uri + "/" + userId);
                if (response.IsSuccessStatusCode)
                {
                    user = await response.Content.ReadAsAsync<User>();
                }
                return user;
            }
        }

        public async Task<User> Update(User user)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.PutAsJsonAsync(uri + "/" + user.Id, user);
                response.EnsureSuccessStatusCode();

                // Deserialize the updated product from the response body.
                user = await response.Content.ReadAsAsync<User>();
                return user;
            }
        }

        public async Task<HttpStatusCode> Delete(int userId)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.DeleteAsync(uri + "/" + userId);
                return response.StatusCode;
            }            
        }
    }
}