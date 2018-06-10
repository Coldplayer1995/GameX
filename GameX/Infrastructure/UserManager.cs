using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameX.DAL;
using GameX.Models;

namespace GameX.Infrastructure
{
    public class UserManager : IUser
    {
        private readonly StoreContext context;

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

        public void SignUp(Users user)
        {
            context.Users.Add(user);
            context.SaveChanges();
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
