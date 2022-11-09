using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace RentACarMVC
{
    public class Common
    {
        public string GetData(string url)
        {
            string temp = "";

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/json";

            
            

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream responseStream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(responseStream))
            {
                temp = reader.ReadToEnd();
            }

            return temp;
        }



    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
}
