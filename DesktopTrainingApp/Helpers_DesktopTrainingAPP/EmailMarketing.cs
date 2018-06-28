using System.Text;
using System.Net;
using System.Data;
using System.IO;
using System.Configuration;
using Newtonsoft.Json;
using BAL_DesktopTrainingAPP;
using System;

namespace Helpers_DesktopTrainingApp
{
    public static class EmailMarketing
    {

        static EmailMarketing()
        {
            GetEmailInfo();
        }

        public static string UserName { get; set; }
        public static string Password { get; set; }
        public static string APIKey { get; set; }
        public static string AcceptKey { get; set; }
        public static string ContentType { get; set; }
        public static string Version { get; set; }
        public static string Email { get; set; }
        public static string CampGid { get; set; }

        public static string api_URL
        {
            get
            {
                return string.Format("http://{0}.api.mailchimp.com/schema/{1}", ConfigurationManager.AppSettings["APIEndPoint"].ToString(), Version);
            }
        }

        private static void GetEmailInfo()
        {
            NewsLetterBLL _objNewsletter = new NewsLetterBLL();
            DataTable dtDetails = _objNewsletter.GetEmailMarketingDetails();
            Version = dtDetails.Rows[0]["Version"].ToString();
            APIKey = dtDetails.Rows[0]["ApiKey"].ToString();
        }
        /// <summary>
        /// Method to send emails to Subscribers list
        /// </summary>
        /// <returns></returns>
        public static string SendEmailsToSUbscriber()
        {
            DataSet set = new DataSet();
            WebClient client = new WebClient();
            string str = "&apikey=" + APIKey + "&type=html&cid=" + CampGid + "&output=json";
            return client.UploadString(string.Format("http://{0}.api.mailchimp.com/3.0/?method=campaignSendNow{1}", Version, str), "");
        }

        /// <summary>
        /// Create a WebClient Object
        /// </summary>
        /// <returns></returns>
        public static WebClient GetWebClient()
        {
            WebClient client = new WebClient();
            try
            {
                client.Headers.Add("Accept", AcceptKey);
                client.Headers.Add("Content-Type", ContentType);
                client.Headers.Add("Api-Version", Version);
                client.Headers.Add("Api-AppId", APIKey);
                client.Headers.Add("Api-Username", UserName);
                client.Headers.Add("API-Password", Password);
            }
            catch (WebException ex)
            {
                throw ex;
            }
            finally
            {
                client.Dispose();
            }
            return client;
        }

        /// <summary>
        /// Convert String to Streams
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public static DataSet ConvertStringToStrream(string response)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(response);
            MemoryStream stream = new MemoryStream(bytes, 0, bytes.Length);
            DataSet set = new DataSet();
            set.ReadXml(stream);
            return set;
        }


        public static DataTable GetLists()
        {
            DataTable table = new DataTable("MchimpLists");
            table.Columns.Add("list_id");
            table.Columns.Add("list_name");

            DataSet set = new DataSet();
            StreamReader reader = null;
            try
            {
                reader = new StreamReader(GetWebClient().OpenRead(api_URL + "/?method=lists&apikey=" + APIKey + "&sort_field=name_Text&sort_dir=ASC&output=json"));
                set.ReadXml(reader);

                if (set != null)
                {
                    if ((set.Tables["id"].Rows.Count <= 0) || (set.Tables["id"] == null))
                    {
                        return table;
                    }
                    else
                    {
                        for (int i = 0; i <= (set.Tables["id"].Rows.Count - 1); i++)
                        {
                            DataRow row = table.NewRow();
                            row["List_id"] = set.Tables["id"].Rows[i]["id_Text"].ToString();
                            row["List_name"] = set.Tables["name"].Rows[i]["name_Text"].ToString();
                            table.Rows.Add(row);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
                reader.Dispose();
            }
            return table;
        }
    }
}
