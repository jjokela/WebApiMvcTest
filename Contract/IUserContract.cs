using Model;
using System.Collections.Generic;

namespace Contract
{
    public interface IUserContract
    {
        IEnumerable<User> GetAllUsers();

        User GetUser(int userId);
    }
}
