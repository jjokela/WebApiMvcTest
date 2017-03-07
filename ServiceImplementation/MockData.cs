using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceImplementation
{
    public class MockData
    {
        public static User GetUser()
        {
            return new User { Id = 1, Name = "Risto Reipas" };
        }

        public static List<User> GetUsers()
        {
            return new List<User>
            {
                new User { Id = 1, Name = "Risto Reipas" },
                new User { Id = 2, Name = "Erno Perälä" },
                new User { Id = 3, Name = "Paavo Väyrynen" }
            };
        }
    }
}
