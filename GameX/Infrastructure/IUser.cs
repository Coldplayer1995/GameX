using GameX.Models;
using GameX.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameX.Infrastructure
{
    public interface IUser
    {
        void Login(LoginViewModel User);

        bool SignUp(SignUpViewModel SignUp);

        void Delete(int UserId);
    }
}
