using System.Net.Http.Headers;
using Internal;
using System.Security.AccessControl;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
 

namespace Httptest{

    class Program3{
        static void Main(string[] args){ Console.WriteLine("cu"); }
    }
    class Requests{
        private string url { get; set; };
        public Requests(string URL) { this.url=URL; }
        public string get(string key) { 

            
            string response = "";
            
            try{ using (WebClient client = new WebClient()){resp = client.DownloadString(this.url); } }
            catch(Exception ex) { response = ""; }
            
            return response;
        }
        public string post() {
            string response = "";
            try { 
                using (WebClient client = new WebClient()){
                    client.Headers[HttpRequestHeader.ContentType]= "application/json";
                    client.Headers.Add()
                } 
            }
        }
    }    
}