using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using CondoQuestionnaire.Server.Repository;
using CondoQuestionnaire.Server.Services.Interface;
using System.Text;

namespace CondoQuestionnaire.Server.Services.Class
{
    public class BaseService : IBaseService
    {
        public IRepositoryFactory RepositoryFactory { get; }

        public BaseService()
        {
            RepositoryFactory = new RepositoryFactory();
        }

        public string Encrypt(string plainText)
        {
            var saltText = "sfvcye654cckas5a";
            byte[] salt = Encoding.UTF8.GetBytes(saltText);

            var hashed = KeyDerivation.Pbkdf2(
                password: plainText,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8);

            return Convert.ToBase64String(hashed);
        }
    }
}
