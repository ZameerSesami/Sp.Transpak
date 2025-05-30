﻿using Newtonsoft.Json;
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
        private string LHDNInvDetailsURL = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "LHDNInvDetailsURL");
        private string grant_type = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "grant_type");
        private string client_id = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "client_id");
        private string client_secret = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "client_secret");
        private string scope = Sp.Transpak.Common.SSOClientHelper.Read("Sp.Transpak", "scope");

        public string SubmitLHDNInvoice(string InvoiceNo, string SupplierTIN, string InvoiceXMLreq, string APIType, string UUID)
        {
            string strtoken = "";
            try
            {
                var token = GetLHDNToken(SupplierTIN);
                strtoken = token.access_token;
                if (APIType == "Submit")
                {
                    var apiresp = ProcessLHDNData(token.access_token, SupplierTIN, InvoiceNo, InvoiceXMLreq);
                    return apiresp;
                }
                else
                {
                    var Invresp = GetLHDNInvoiceDetails(strtoken, SupplierTIN, InvoiceNo, UUID);
                    return Invresp;
                }
                //return "OK" + token;
            }
            catch (Exception ex)
            {
                return "Error:" + ex.Message + "Token: " + strtoken;
            }
        }

        public string ProcessLHDNData(string LHDNToken, string SupplierTIN, string InvoiceNo, string InvoiceXMLreq)
        {
            //InvoiceXMLreq = "<Invoice xmlns='urn:oasis:names:specification:ubl:schema:xsd:Invoice-2' xmlns:cac='urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2' xmlns:cbc='urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2'> 	<cbc:ID>SESAMiTest42</cbc:ID> 	<cbc:IssueDate>2025-01-26</cbc:IssueDate> 	<cbc:IssueTime>10:20:42Z</cbc:IssueTime> 	<cbc:InvoiceTypeCode listVersionID='1.0'>01</cbc:InvoiceTypeCode> 	<cbc:DocumentCurrencyCode>MYR</cbc:DocumentCurrencyCode> 	<cac:AccountingSupplierParty> 		<cac:Party> 			<cbc:IndustryClassificationCode>52292</cbc:IndustryClassificationCode> 			<cac:PartyIdentification> 				<cbc:ID schemeID='TIN'>C5869047060</cbc:ID> 			</cac:PartyIdentification> 			<cac:PartyIdentification> 				<cbc:ID schemeID='BRN'>199201003526</cbc:ID> 			</cac:PartyIdentification> 			<cac:PostalAddress> 				<cbc:CityName>JOHOR BAHRU</cbc:CityName> 				<cbc:PostalZone>81100</cbc:PostalZone> 				<cbc:CountrySubentityCode>17</cbc:CountrySubentityCode> 				<cac:AddressLine> 					<cbc:Line>#01-16 #02-16 JALAN MOLEK 1/31 TAMAN MOLEK</cbc:Line> 				</cac:AddressLine> 				<cac:AddressLine> 					<cbc:Line>#01-16 #02-16 JALAN MOLEK 1/31 TAMAN MOLEK</cbc:Line> 				</cac:AddressLine> 				<cac:AddressLine> 					<cbc:Line>#01-16 #02-16 JALAN MOLEK 1/31 TAMAN MOLEK</cbc:Line> 				</cac:AddressLine> 				<cac:Country> 					<cbc:IdentificationCode>MY</cbc:IdentificationCode> 				</cac:Country> 			</cac:PostalAddress> 			<cac:PartyLegalEntity> 				<cbc:RegistrationName>WAN HAI LINES (M) SDN BHD</cbc:RegistrationName> 			</cac:PartyLegalEntity> 			<cac:Contact> 				<cbc:Telephone>073608000</cbc:Telephone> 				<cbc:ElectronicMail>alvin_chua@wanhai.com</cbc:ElectronicMail> 			</cac:Contact> 		</cac:Party> 	</cac:AccountingSupplierParty> 	<cac:AccountingCustomerParty> 		<cac:Party> 			<cac:PartyIdentification> 				<cbc:ID schemeID='TIN'>C4855583050</cbc:ID> 			</cac:PartyIdentification> 			<cac:PartyIdentification> 				<cbc:ID schemeID='BRN'>198801006325</cbc:ID> 			</cac:PartyIdentification> 			<cac:PostalAddress> 				<cbc:CityName>BANDAR BARU BANGI</cbc:CityName> 				<cbc:PostalZone>43650</cbc:PostalZone> 				<cbc:CountrySubentityCode>17</cbc:CountrySubentityCode> 				<cac:AddressLine> 					<cbc:Line>LOT 3  JALAN 6C/12  SEKSYEN 16</cbc:Line> 				</cac:AddressLine> 				<cac:AddressLine> 					<cbc:Line>LOT 3  JALAN 6C/12  SEKSYEN 16</cbc:Line> 				</cac:AddressLine> 				<cac:AddressLine> 					<cbc:Line>LOT 3  JALAN 6C/12  SEKSYEN 16</cbc:Line> 				</cac:AddressLine> 				<cac:Country> 					<cbc:IdentificationCode>MY</cbc:IdentificationCode> 				</cac:Country> 			</cac:PostalAddress> 			<cac:PartyLegalEntity> 				<cbc:RegistrationName>LOGISTEED MALAYSIA SDN BHD</cbc:RegistrationName> 			</cac:PartyLegalEntity> 			<cac:Contact> 				<cbc:Telephone>389131000</cbc:Telephone> 				<cbc:ElectronicMail>alvin_chua@wanhai.com</cbc:ElectronicMail> 			</cac:Contact> 		</cac:Party> 	</cac:AccountingCustomerParty> 	<cac:PaymentTerms> 		<cbc:Note>30 Days</cbc:Note> 	</cac:PaymentTerms> 	<cac:TaxTotal> 		<cbc:TaxAmount currencyID='MYR'>0.00</cbc:TaxAmount> 		<cac:TaxSubtotal> 			<cbc:TaxableAmount currencyID='MYR'>40.00</cbc:TaxableAmount> 			<cbc:TaxAmount currencyID='MYR'>0.00</cbc:TaxAmount> 			<cac:TaxCategory> 				<cbc:ID>01</cbc:ID> 				<cac:TaxScheme> 					<cbc:ID schemeID='UN/ECE 5153' schemeAgencyID='6'>OTH</cbc:ID> 				</cac:TaxScheme> 			</cac:TaxCategory> 		</cac:TaxSubtotal> 	</cac:TaxTotal> 	<cac:LegalMonetaryTotal> 		<cbc:LineExtensionAmount currencyID='MYR'>40.00</cbc:LineExtensionAmount> 		<cbc:TaxExclusiveAmount currencyID='MYR'>40.00</cbc:TaxExclusiveAmount> 		<cbc:TaxInclusiveAmount currencyID='MYR'>40.00</cbc:TaxInclusiveAmount> 		<cbc:PrepaidAmount currencyID='MYR'>0</cbc:PrepaidAmount> 		<cbc:PayableAmount currencyID='MYR'>40.00</cbc:PayableAmount> 	</cac:LegalMonetaryTotal> 	<cac:InvoiceLine> 		<cbc:ID>1</cbc:ID> 		<cbc:InvoicedQuantity unitCode='C62'>1</cbc:InvoicedQuantity> 		<cbc:LineExtensionAmount currencyID='MYR'>40</cbc:LineExtensionAmount> 		<cac:TaxTotal> 			<cbc:TaxAmount currencyID='MYR'>0</cbc:TaxAmount> 			<cac:TaxSubtotal> 				<cbc:TaxableAmount currencyID='MYR'>40</cbc:TaxableAmount> 				<cbc:TaxAmount currencyID='MYR'>0</cbc:TaxAmount> 				<cbc:Percent>0</cbc:Percent> 				<cac:TaxCategory> 					<cbc:ID>O</cbc:ID> 					<cac:TaxScheme> 						<cbc:ID schemeID='UN/ECE 5153' schemeAgencyID='6'>OTH</cbc:ID> 					</cac:TaxScheme> 				</cac:TaxCategory> 			</cac:TaxSubtotal> 		</cac:TaxTotal> 		<cac:Item> 			<cbc:Description>CONTAINER CLEANING FEE</cbc:Description> 			<cac:CommodityClassification> 				<cbc:ItemClassificationCode listID='CLASS'>022</cbc:ItemClassificationCode> 			</cac:CommodityClassification> 			<cac:CommodityClassification> 				<cbc:ItemClassificationCode listID='SSU'>006</cbc:ItemClassificationCode> 			</cac:CommodityClassification> 		</cac:Item> 		<cac:Price> 			<cbc:PriceAmount currencyID='MYR'>40</cbc:PriceAmount> 		</cac:Price> 		<cac:ItemPriceExtension> 			<cbc:Amount currencyID='MYR'>40</cbc:Amount> 		</cac:ItemPriceExtension> 	</cac:InvoiceLine> </Invoice>";
            string lineno = "1";
            try
            {
                // Remove all new lines and tabs
                InvoiceXMLreq = InvoiceXMLreq.Replace("\r\n", "").Replace("\n", "").Replace("\t", "");
                InvoiceXMLreq = System.Text.RegularExpressions.Regex.Replace(InvoiceXMLreq, @">\s+<", "><");

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
                DocumentModel docModel = new DocumentModel();
                docModel.format = "XML";
                docModel.codeNumber = InvoiceNo;
                docModel.document = base64String;
                docModel.documentHash = hashHexString;

                LHDNInvoiceRequestModel req = new LHDNInvoiceRequestModel();
                req.documents = new List<DocumentModel>();
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
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    // Send the POST request to obtain the access token
                    HttpResponseMessage response = httpClient.PostAsync(LHDNInvSubmitURL, content).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    if (response.IsSuccessStatusCode)
                    {
                        LHDNInvoiceResponse myLHDNresponse = JsonConvert.DeserializeObject<LHDNInvoiceResponse>(result);
                        if (result.Contains("uuid"))
                        {
                            //return myLHDNresponse.acceptedDocuments[0].uuid;
                            return "<PeppolAPIResponse><Succeed>true</Succeed><Timestamp>" + DateTime.Now.ToString() + "</Timestamp><InvoiceSubmissionID>" + myLHDNresponse.acceptedDocuments[0].uuid + "</InvoiceSubmissionID></PeppolAPIResponse>";
                        }
                        else
                        {
                            System.Text.StringBuilder sb = new System.Text.StringBuilder();
                            foreach (var item in myLHDNresponse.rejectedDocuments[0].error.details)
                            {
                                sb.Append(item.message);
                                sb.Append(" | ");
                            }
                            return "<PeppolAPIResponse><Succeed>false</Succeed><Timestamp>" + DateTime.Now.ToString() + "</Timestamp><ErrorDescription>" + sb.ToString() + "</ErrorDescription></PeppolAPIResponse>";
                        }
                    }
                    else
                    {
                        return "<PeppolAPIResponse><Succeed>false</Succeed><Timestamp>" + DateTime.Now.ToString() + "</Timestamp><ErrorDescription>" + "Reason Phrase: " + response.ReasonPhrase + " Error:" + result + "</ErrorDescription></PeppolAPIResponse>";
                    }
                    //return response.ReasonPhrase + "###token:" + LHDNToken + "###content:" + jsonString.ToString();
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

        public string GetLHDNInvoiceDetails(string LHDNToken, string SupplierTIN, string InvoiceNo, string UUID)
        {
            LHDNInvoiceDetails invoiceDetails = new LHDNInvoiceDetails();
            string longID = string.Empty;
            string errorMessage = string.Empty;
            try
            {
                // Append path variable to the URL
                string url = LHDNInvDetailsURL + "/" + UUID + "/details";

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
                ServicePointManager.ServerCertificateValidationCallback = (snder, cert, chain, error) => true;

                HttpClientHandler handler = new HttpClientHandler();
                using (var httpClient = new HttpClient(handler))
                {
                    // Configure the client with your DS certificate for client authentication    
                    httpClient.BaseAddress = new Uri(url);
                    httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + LHDNToken);
                    //httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "F3E7DB5C-D57C-4103-8B46-99AF3E8267CE");// Set the value of authorization header for HTTP Request.
                    httpClient.Timeout = TimeSpan.FromSeconds(300);
                    // Send the POST request to obtain the access token
                    HttpResponseMessage response = httpClient.GetAsync(url).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    if (response.IsSuccessStatusCode)
                    {
                        invoiceDetails = JsonConvert.DeserializeObject<LHDNInvoiceDetails>(result);
                        if (invoiceDetails.status == "Valid")
                        {
                            return "<APIResponse><InvoiceNumber>" + InvoiceNo + "</InvoiceNumber><UUID>" + UUID + "</UUID><LongID>" + invoiceDetails.longId + "</LongID><StatusCode>Valid</StatusCode><StatusMessage>-</StatusMessage><ValidationDateTime>" + invoiceDetails.dateTimeValidated.ToString() + "</ValidationDateTime><InterfaceStatus>Valid</InterfaceStatus><LHDNResponse>" + result.ToString().Replace("\\n", "").Replace("\\", "").Replace("&", "&amp;").Replace("'", "`").Replace(",", "-") + "</LHDNResponse></APIResponse>";
                        }
                        else
                        {
                            return "<APIResponse><InvoiceNumber>" + InvoiceNo + "</InvoiceNumber><UUID>" + UUID + "</UUID><LongID>" + invoiceDetails.longId + "</LongID><StatusCode>Invalid</StatusCode><StatusMessage>" + result.ToString().Replace("\\n", "").Replace("\\", "").Replace("&", "&amp;").Replace("'", "`").Replace(",", "-") + "</StatusMessage><ValidationDateTime>" + invoiceDetails.dateTimeValidated.ToString() + "</ValidationDateTime><InterfaceStatus>Invalid</InterfaceStatus><LHDNResponse>" + result.ToString().Replace("\\n", "").Replace("\\", "").Replace("&", "&amp;").Replace("'", "`").Replace(",", "-") + "</LHDNResponse></APIResponse>";
                        }
                        //if (string.IsNullOrEmpty(invoiceDetails.longId) && invoiceDetails.status == "Invalid")
                        //{
                        //    string replaceData = result.ToString();
                        //    replaceData = replaceData.Replace("\\n", "").Replace("\\", "");
                        //    errorMessage = result.ToString().Replace("\\n", "").Replace("\\", "");
                        //    return "<APIResponse><UUID>" + url + "</UUID><Timestamp>" + DateTime.Now.ToString() + "</Timestamp><InvoiceSubmissionID>" + result + "</InvoiceSubmissionID></PeppolAPIResponse>";
                        //    return "<PeppolAPIResponse><Succeed>false</Succeed><Timestamp>" + DateTime.Now.ToString() + "</Timestamp><ErrorDescription>" + errorMessage + "</ErrorDescription></PeppolAPIResponse>";

                        //}
                        //if (invoiceDetails.validationResults != null)
                        //{
                        //    if (!string.IsNullOrEmpty(invoiceDetails.validationResults.status) && invoiceDetails.validationResults.status == "Invalid")
                        //    {
                        //        string message = string.Empty;
                        //        foreach (var data in invoiceDetails.validationResults.validationSteps)
                        //        {
                        //            if (data.status == "Invalid")
                        //            {
                        //                // Serialize the object to JSON
                        //                string jsonString = JsonConvert.SerializeObject(data.error, Formatting.Indented);
                        //                message = message == "" ? jsonString : message + "," + jsonString;
                        //            }
                        //        }
                        //        errorMessage = message.ToString().Replace("\\n", "").Replace("\\", "");
                        //        return errorMessage;
                        //    }
                        //}
                        //return result;
                    }
                    else
                    {
                        errorMessage = "HTTP Status Code : " + (int)response.StatusCode + ", Reason Phrase: " + response.ReasonPhrase;
                        return "<APIResponse><UUID>" + UUID + "</UUID><LongID>" + invoiceDetails.longId + "</LongID><StatusCode>Invalid</StatusCode><StatusMessage>" + errorMessage + "</StatusMessage><InterfaceStatus>Invalid</InterfaceStatus><LHDNResponse>" + errorMessage + "</LHDNResponse></APIResponse>";
                    }
                    //return invoiceDetails;
                }
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return errorMessage;
            }
        }

        public LHDNTokenResponse GetLHDNToken(string SupplierTIN)
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
                client.DefaultRequestHeaders.Add("onbehalfof", SupplierTIN);

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
