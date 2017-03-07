using Contract;
using System.Collections.Generic;
using Model;

namespace ServiceImplementation
{
    public class ServiceImplementation : IUserContract
    {
        public IEnumerable<User> GetAllUsers()
        {
            return MockData.GetUsers();
        }

        public User GetUser(int userId)
        {
            return MockData.GetUser();
        }
    }
}
