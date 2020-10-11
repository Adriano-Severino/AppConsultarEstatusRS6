using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace EstatusRs6.Core.Services
{
    public abstract class Service
    {
        protected HttpClient _client;
        protected string BaseApiUrl = "https://r6.apitab.com/search";
        protected string BaseApiUrlLeaderboards = "https://r6.apitab.com/leaderboards";

        public Service()
        {
            _client = new HttpClient();
        }
    }
}
