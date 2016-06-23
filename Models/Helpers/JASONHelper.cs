using DataObjectsProject;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Services.WebApi;

namespace Models.Helpers
{
    public static class JASONHelper
    {
        public delegate void JSONReturnCallBack(string jasonReturnString, string returnType);


        public static async void Post(string url, System.Net.Http.HttpContent wiPostDataContent, string returnType, JSONReturnCallBack callBack)
        {
           string responseString = String.Empty;
           try
           {
                
                using (HttpClient client = new System.Net.Http.HttpClient())
                {

                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json-patch+json"));
 
                  
                    client.DefaultRequestHeaders.Authorization = 
                                 new AuthenticationHeaderValue("Basic",Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(getConnectionDetails())));

                    using (System.Net.Http.HttpResponseMessage response = client.PostAsync(SetURL(url), wiPostDataContent).Result)
                      {
                            response.EnsureSuccessStatusCode();
                            string ResponseContent = await response.Content.ReadAsStringAsync();

                            responseString = ResponseContent;

                      }
                }
            }
            catch(Exception ex)
            {
                            Console.WriteLine(ex.ToString());
                            Console.ReadLine();
            }
           callBack(responseString,returnType);
        }

        private static string getConnectionDetails()
        {
            var data = Models.Bug.Queries.SettingQuery.UserDetails();
            return string.Format("{0}:{1}", data.Username, data.Password);
        }

        public static async void Patch(string url,  System.Net.Http.HttpContent wiPostDataContent, JSONReturnCallBack callBack)
        {
            string responseString = String.Empty;
            try
            {

                using (HttpClient client = new System.Net.Http.HttpClient())
                {

                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json-patch+json"));


                    client.DefaultRequestHeaders.Authorization =
                                 new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(getConnectionDetails())));
            
                    

                  
                    using (System.Net.Http.HttpResponseMessage response = client.PatchAsync(SetURL(url), wiPostDataContent).Result)
                    {
                        response.EnsureSuccessStatusCode();
                        string ResponseContent = await response.Content.ReadAsStringAsync();

                        responseString = ResponseContent;

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            callBack(responseString, String.Empty);
        }


        public static async void PostSimple(string url, string binaryString, JSONReturnCallBack callBack)
        {
            string responseString = String.Empty;
            try
            {
                using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
                {


                    client.DefaultRequestHeaders.Authorization =
                                 new AuthenticationHeaderValue("Basic", Convert.ToBase64String(System.Text.ASCIIEncoding.ASCII.GetBytes(getConnectionDetails())));


                    using (System.Net.Http.HttpResponseMessage response = client.PostAsync(SetURL(url), new StringContent(binaryString,Encoding.UTF8,"application/json")).Result)
                    {
                        response.EnsureSuccessStatusCode();
                        responseString = await response.Content.ReadAsStringAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            callBack(responseString, "file");
        }



        public static string SetURL(string url)
        {
            string project = Models.Bug.Queries.SettingQuery.SingleValue(Bug.ENUMS.SettingENUM.VSOProject);
            string account = Models.Bug.Queries.SettingQuery.SingleValue(Bug.ENUMS.SettingENUM.VSOAccount);

            url = url.Replace("[ACCOUNT]", account);
            url = url.Replace("[PROJECT]", project);

            return url;
        }
     



    }

}
