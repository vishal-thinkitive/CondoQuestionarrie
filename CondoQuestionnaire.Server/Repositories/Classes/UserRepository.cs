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
    public class UserRepository : BaseRepository, IUserRepository
    {
        public async Task<List<Register>> GetAllUsers()
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                var jsonString = File.ReadAllText(jsonFile);

                var userList = new List<Register>();

                userList = JsonConvert.DeserializeObject<List<Register>>(jsonString);

                if (userList is not null)
                { 
                    return userList; 
                }
                else
                {
                    throw new NullReferenceException();
                }

                
            }
            catch (Exception ex)
            {
                return new List<Register>();
            }
        }

        public async Task<Register> GetUserByEmail(string email)
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                var jsonString = File.ReadAllText(jsonFile);

                var userList = new List<Register>();

                userList = JsonConvert.DeserializeObject<List<Register>>(jsonString);

                if (userList is not null)
                {
                    var user = userList.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
                    if (user is not null)
                    {
                        return user;
                    }
                    else
                    {
                        throw new NullReferenceException();
                    }
                }
                else
                {
                    throw new NullReferenceException();
                }


            }
            catch (Exception ex)
            {
                return new Register();
            }
        }

        public async Task<bool> UpdateUserByEmail(string email, Register updateduser)
        {
            try
            {
                //Json convertion
                var jsonFile = "./user.json";
                var jsonString = File.ReadAllText(jsonFile);

                var userList = new List<Register>();

                userList = JsonConvert.DeserializeObject<List<Register>>(jsonString);

                if (userList is not null)
                {
                    var user = userList.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
                    if (user is not null)
                    {
                        userList.Remove(user);
                        userList.Add(updateduser);
                        var newUserList = JsonConvert.SerializeObject(userList);
                        File.WriteAllText(jsonFile, newUserList);
                        return true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    throw new Exception();
                }


            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
