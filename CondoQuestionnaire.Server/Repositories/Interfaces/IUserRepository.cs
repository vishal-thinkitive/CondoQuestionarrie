using CondoQuestionnaire.Server.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Server.Repository.Interface
{
    public interface IUserRepository
    {
        Task<List<Register>> GetAllUsers();
        Task<Register> GetUserByEmail(string email);
        Task<bool> UpdateUserByEmail(string email, Register updateduser);

    }
}
