using CondoQuestionnaire.Server.DataModel;
using Newtonsoft.Json;
using CondoQuestionnaire.Server.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Server.Repository.Class
{
    public class LogInRepository : BaseRepository, ILogInRepository
    {
        public async Task<bool> LogInUser(LogIn logInUserObj)
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                if (!File.Exists(jsonFile))
                {
                    using (FileStream fs = File.Create(jsonFile)) ;
                }

                var jsonString = File.ReadAllText(jsonFile);
                var userList = JsonConvert.DeserializeObject<List<Register>>(jsonString);

                if (userList is not null)
                {
                    var currentUser = userList.FirstOrDefault(x => x.Email.ToLower() == logInUserObj.UserName.ToLower()); //&& x.IsRegistered);

                    if (currentUser is not null && currentUser.Password == logInUserObj.Password)
                    {
                        return true;
                    }
                    else
                    {
                        throw new InvalidDataException();
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
