using GameX.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.Infrastructure
{
    public interface IUser
    {
        void Login();

        void SignUp(Users Event);

        void Delete(int UserId);
    }
}
