using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Settings.Constants
{
    /// <summary>
    /// MGM apisi isteklerinde kullanılacak header bilgilerini tutan sınıf
    /// </summary>
    public class MGMHttpHeaders
    {
        /// <summary>
        /// MGM API isteklerinde kullanılacak header bilgileri
        /// </summary>
        public static readonly Dictionary<string, string> MGM_HEADERS = new Dictionary<string, string>
        {
            { "Host", "servis.mgm.gov.tr" },
            { "Connection", "keep-alive" },
            { "Accept", "application/json, text/plain, */*" },
            { "User-Agent", " Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.122 Safari/537.36" },
            { "Origin", "https://www.mgm.gov.tr" },
        };
    }
}
