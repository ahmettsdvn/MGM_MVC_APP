using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Settings
{
    /// <summary>
    /// MGM API Url'lerini tutan sınıf
    /// </summary>
    public class Urls
    {
        /// <summary>
        /// Ana API Url
        /// </summary>
        public const string MGM_API_BASE_URL = "https://servis.mgm.gov.tr";

        /// <summary>
        /// MGM API Türkiyedeki 81 İl merkez ilçe istasyonlarının bilgilerini çekmek için kullanılan URL 
        /// </summary>
        public const string MGM_API_ILLER_URL = "https://servis.mgm.gov.tr/web/merkezler/iller";

        /// <summary> 
        /// MGM API Belirli bir ildeki istasyon bilgilerini çekmek için kullanılan URL
        /// <para> Kullanımı: MGM_API_IL_ISTASYON_BILGILERI + "İlAdı" </para>
        /// <para> Örnek: https://servis.mgm.gov.tr/web/merkezler?il=BOLU </para>
        /// </summary>
        public const string MGM_API_IL_ISTASYON_BILGILERI = "https://servis.mgm.gov.tr/web/merkezler?il=";
    }
}
