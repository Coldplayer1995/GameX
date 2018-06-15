using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameX.DAL;
using GameX.Models;
using GameX.ViewModel;

namespace GameX.Infrastructure
{
    public class UserManager : IUser
    {
        private readonly StoreContext context;

        public UserManager(StoreContext context)
        {
            this.context = context;
        }

        public void Login()
        {
            try
            {
                
            }

            catch(Exception ex)
            {
                throw;
            }
        }

        public void SignUp(SignUpViewModel SignUp)
        {
            Users User = new Users
            {
                Name = SignUp.Name,
                Surname = SignUp.Surname,
                Email = SignUp.Email,
                Username = SignUp.Username,
                Password = SignUp.Password
            };

            try { 
                context.Users.Add(User);
                context.SaveChanges();
            }

            catch(Exception ex)
            {
                throw;
            }
        }

        public void Delete(int UserId)
        {
            Users User = context.Users.FirstOrDefault(x => x.UserId == UserId);

            try
            {
                context.Users.Remove(User);
            }

            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
