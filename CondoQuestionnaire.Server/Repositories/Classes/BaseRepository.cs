using CondoQuestionnaire.Server.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CondoQuestionnaire.Server.Repository.Class
{
    public class BaseRepository : IBaseRepository
    {
        public string GetDataByURL(string url)
        {
            try
            {
                WebRequest request = HttpWebRequest.Create(url);
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                string urlText = reader.ReadToEnd(); // it takes the response from your url. now you can use as your need  
                return (urlText.ToString());
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
    }
}
