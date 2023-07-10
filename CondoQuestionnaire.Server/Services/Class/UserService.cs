using CondoQuestionnaire.Server.DataModel;
using CondoQuestionnaire.Server.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Server.Services.Class
{
    public class UserService : BaseService, IUserService
    {
        public async Task<List<Register>> GetAllUsers()
        {
            try
            {
                var result = await RepositoryFactory.UserRepository.GetAllUsers();
                return result;
            }
            catch(Exception ex)
            {
                var user = new List<Register>();
                return user;
            }
        }

        public async Task<Register> GetUserByEmail(string email)
        {
            try
            {
                var result = await RepositoryFactory.UserRepository.GetUserByEmail(email);
                return result;
            }
            catch (Exception ex)
            {
                return new Register();
            }
        }

        public async Task<bool> UpdateUserByEmail(string email, Register updatedUser)
        {
            try
            {
                var result = await RepositoryFactory.UserRepository.UpdateUserByEmail(email, updatedUser);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
