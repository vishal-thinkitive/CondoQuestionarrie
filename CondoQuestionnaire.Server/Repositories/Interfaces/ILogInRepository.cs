using CondoQuestionnaire.Server.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Server.Repository.Interface
{
    public interface ILogInRepository
    {
        Task<bool> LogInUser(LogIn logInUserObj);
    }
}
