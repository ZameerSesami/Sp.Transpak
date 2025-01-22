using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Sp.Transpak.CallAPI
{
    [Serializable]
    public class LHDNInvoiceAPI
    {
        private string LHDNAPITokenURL = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "LHDNAPITokenURL");
        private string LHDNInvSubmitURL = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "LHDNInvSubmitURL");
        private string grant_type = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "grant_type");
        private string client_id = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "client_id");
        private string client_secret = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "client_secret");
        private string scope = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "scope");

        public string SubmitLHDNInvoice(string InvoiceNo, string InvoiceXMLreq)
        {
            string strtoken = "";
            try
            {
                var token = GetLHDNToken();
                strtoken = token.access_token;
                var apiresp = ProcessLHDNData(token.access_token, InvoiceNo, InvoiceXMLreq);
                return apiresp;
                //return "OK" + token;
            }
            catch (Exception ex)
            {
                return "Error:" + ex.Message + "Token: " + strtoken;
            }
        }

        public string ProcessLHDNData(string LHDNToken, string InvoiceNo, string InvoiceXMLreq)
        {
            string lineno = "1";
            try
            {
                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(InvoiceXMLreq);
                string base64String = Convert.ToBase64String(bytes);
                lineno = "2";
                byte[] hashBytes;
                using (SHA256 sha256 = SHA256.Create())
                {
                    hashBytes = sha256.ComputeHash(bytes);
                }
                lineno = "3";
                // Convert hash to hexadecimal string
                string hashHexString = BitConverter.ToString(hashBytes).Replace("-", "");
                lineno = "4";
                Document docModel = new Document();
                docModel.format = "XML";
                docModel.codeNumber = InvoiceNo;
                docModel.document = base64String;
                docModel.documentHash = hashHexString;

                LHDNInvoiceRequestModel req = new LHDNInvoiceRequestModel();
                req.documents = new List<Document>();
                req.documents.Add(docModel);
                lineno = "5";
                //string jsonString = JsonConvert.SerializeObject(req);
                var jsonString = new JavaScriptSerializer().Serialize(req);

                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                HttpClientHandler handler = new HttpClientHandler();
                using (var httpClient = new HttpClient(handler))
                {
                    // Configure the client with your DS certificate for client authentication    
                    httpClient.BaseAddress = new Uri(LHDNInvSubmitURL);
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + LHDNToken);
                    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "F3E7DB5C-D57C-4103-8B46-99AF3E8267CE");// Set the value of authorization header for HTTP Request.

                    HttpContent content = new StringContent(jsonString);
                    // Send the POST request to obtain the access token
                    HttpResponseMessage response = httpClient.PostAsync(LHDNInvSubmitURL, content).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    return response.ReasonPhrase + "code:" + response.StatusCode + result + "Token:" + LHDNToken + "jsonstring:" + jsonString;
                }





                //create RestSharp client and POST request object
                //var client = new RestClient(LHDNInvSubmitURL);
                //var request = new RestRequest();
                //request.Method = Method.POST;
                ////request headers
                //request.RequestFormat = DataFormat.Json;
                //request.AddHeader("Content-Type", "application/json");
                //lineno = "6";
                ////add parameters and token to request
                //request.AddParameter("application/json", JsonConvert.SerializeObject(req), ParameterType.RequestBody);
                //request.AddParameter("Authorization", "Bearer " + LHDNToken, ParameterType.HttpHeader);
                //lineno = "7";
                ////make the API request and get a response
                //var response = client.Execute(request);
                //lineno = "8";
                //return response.Content;
            }
            catch (Exception ex)
            {
                return ex.Message + "###LineNo:" + lineno;
            }

        }

        public LHDNTokenResponse GetLHDNToken()
        {
            //Root jsonObject = new Root();
            using (var client = new HttpClient())
            {
                var headerreq = new List<KeyValuePair<string, string>>();
                headerreq.Add(new KeyValuePair<string, string>("grant_type", grant_type));
                headerreq.Add(new KeyValuePair<string, string>("client_id", client_id));
                headerreq.Add(new KeyValuePair<string, string>("client_secret", client_secret));
                headerreq.Add(new KeyValuePair<string, string>("scope", scope));

                HttpContent content = new FormUrlEncodedContent(headerreq);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                //System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

                client.BaseAddress = new Uri(LHDNAPITokenURL);
                client.DefaultRequestHeaders.Add("onbehalfof", "IG25477901080");

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback = (snder, cert, chain, error) => true;

                System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                var responseResult = client.PostAsync(LHDNAPITokenURL, content).Result;

                return Newtonsoft.Json.JsonConvert.DeserializeObject<LHDNTokenResponse>(responseResult.Content.ReadAsStringAsync().Result);
                //return responseResult.Content.ReadAsStringAsync().Result;
            }
        }
    }
}
