using CondoQuestionnaire.Server.DataModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using CondoQuestionnaire.Server.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DocuSign.eSign.Model;

namespace CondoQuestionnaire.Server.Repository.Class
{
    public class RegisterRepository : BaseRepository, IRegisterRepository
    {
        public async Task<bool> RegisterUser(Register registerUser)
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
                
                if (userList is not null && !userList.Any(x=>x.Email.ToLower() == registerUser.Email.ToLower()))
                {
                    userList.Add(registerUser);
                    var newUserList = JsonConvert.SerializeObject(userList);
                    File.WriteAllText(jsonFile, newUserList);
                }
                else
                {

                    var newRegiterList = JsonConvert.SerializeObject(new List<Register> { registerUser });
                    File.WriteAllText(jsonFile, newRegiterList);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
