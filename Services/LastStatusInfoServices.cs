using Common;
using Common.LastStatus;
using Common.Settings;
using Common.Settings.Constants;
using Services.Infrastructre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LastStatusInfoServices : ILastStatusInfo
    {
        private readonly BaseHttpClient _client;

        public LastStatusInfoServices(BaseHttpClient client)
        {
                _client = client;
        }

        public LastStatusInfo GetLastStatusInfo(int centerıd)
        {
            var result = _client.GetAsync<LastStatusInfo>(UriHelper.MGM_API_SON_DURUMLAR(centerıd), MGMHttpHeaders.MGM_HEADERS).Result;
            return result;
        }
    }
}
