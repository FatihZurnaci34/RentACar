using Entities.Concrete;
using Entities.ViewModels;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
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

        public string PostData(string url, VMBrandAdd brand)
        {
            string temp = "";

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            using (Stream requestStream = request.GetRequestStream())
            using (StreamWriter writer = new StreamWriter(requestStream, Encoding.ASCII))
            {
                writer.Write(JsonConvert.SerializeObject(brand));
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            using (StreamReader reader = new StreamReader(responseStream))
            {
                temp = reader.ReadToEnd();
            }

            return temp;
        }

        public string DeleteData(string url,Car car)
        {
            string temp = "";

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            using (Stream requestStream = request.GetRequestStream())
            using (StreamWriter writer = new StreamWriter(requestStream, Encoding.ASCII))
            {
                writer.Write(JsonConvert.SerializeObject(car));
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            using (StreamReader reader = new StreamReader(responseStream))
            {
                temp = reader.ReadToEnd();
            }
            return temp;
        }

        public string PutData(string url, Car car)
        {
            string temp = "";

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";

            using (Stream requestStream = request.GetRequestStream())
            using (StreamWriter writer = new StreamWriter(requestStream, Encoding.ASCII))
            {
                writer.Write(JsonConvert.SerializeObject(car));
            }

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            using (StreamReader reader = new StreamReader(responseStream))
            {
                temp = reader.ReadToEnd();
            }

            return temp;
        }



    }


    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
}
