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
    public class UriHelper
    {
        /// <summary>
        /// Ana API Url
        /// </summary>
        private readonly static string MGM_API_BASE_URL = "https://servis.mgm.gov.tr";

        /// <summary>
        /// MGM API Türkiyedeki 81 İl merkez ilçe istasyonlarının bilgilerini çekmek için kullanılan URL 
        /// </summary>
        public static string MGM_API_ILLER_URL()
        {
            string url = "web/merkezler/iller";

            return $"{MGM_API_BASE_URL}/{url}";
        }

        /// <summary>
        /// MGM API Belirli bir ildeki istasyon bilgilerini çekmek için kullanılan URL
        /// <para> Kullanımı: MGM_API_IL_ISTASYON_BILGILERI + "İlAdı" </para>
        /// <para> Örnek: https://servis.mgm.gov.tr/web/merkezler?il=BOLU </para>
        /// </summary>
        public static string MGM_API_IL_ISTASYON_BILGILERI(string cityName)
        {
            string url = $"web/merkezler?il={cityName.ToLower()}";

            return $"{MGM_API_BASE_URL}/{url}";
        }

        /// <summary>
        /// MGM API Belirli bir ilin ilesindeki istasyon bilgilerini çekmek için kullanılan URL
        /// <para> Kullanımı: MGM_API_IL_ISTASYON_BILGILERI + "İlAdı" +ilceAdi </para>
        /// <para> Örnek: https://servis.mgm.gov.tr/web/merkezler?il=BOLU </para>
        /// </summary>
        public static string MGM_API_IL_ILCE_ISTASYON_BILGILERI(string cityName, string districtName)
        {
            string url = $"web/merkezler?il={cityName.ToLower()}&ilce={districtName.ToLower()}";

            return $"{MGM_API_BASE_URL}/{url}";
        }

        /// <summary>
        /// MGM API Belirli bir ilin tüm istasyon bilgilerini çekmek için kullanılan URL
        /// <para> Kullanımı: MGM_API_IL_ISTASYON_BILGILERI_HEPSI + "İlAdı" </para>
        /// <para> Örnek: https://servis.mgm.gov.tr/web/merkezler?il=BOLU </para>
        /// </summary>
        public static string MGM_API_IL_ISTASYON_BILGILERI_HEPSI(string cityName)
        {
            string url = $"web/merkezler/ililcesi?il={cityName.ToLower()}";

            return $"{MGM_API_BASE_URL}/{url}";
        }

        /// <summary>
        /// İstasyonun 5 günlük hava durumu ve sıcaklık bilgilerini çekmek için kullanılan URL
        /// </summary>
        /// <param name="stationId"></param>
        /// <returns></returns>
        public static string MGM_API_GUNLUK_HAVA_DURUMU(int stationId)
        {
            string url = $"web/tahminler/gunluk?istno={stationId}";
            return $"{MGM_API_BASE_URL}/{url}";
        }

        /// <summary>
        /// İstasyonun saatlik hava durumu ve sıcaklık bilgilerini çekmek için kullanılan URL
        /// </summary>
        /// <param name="stationId"></param>
        /// <returns></returns>
        public static string MGM_API_SAATLIK_HAVA_DURUMU(int stationId)
        {
            string url = $"web/tahminler/saatlik?istno={stationId}";
            return $"{MGM_API_BASE_URL}/{url}";
        }

        /// <summary>
        /// İstasyonun son durum bilgilerini çekmek için kullanılan URL
        /// </summary>
        /// <param name="centerId"></param>
        /// <returns></returns>
        public static string MGM_API_SON_DURUMLAR(int centerId)
        {
            string url = $"web/sondurumlar?merkezid={centerId}";
            return $"{MGM_API_BASE_URL}/{url}";
        }

        /// <summary>
        /// Tüm istasyonlar
        /// </summary>
        /// <returns></returns>
        public static string MGM_TUM_ISTASYONLAR()
        {
            var url = "web/istasyonlar";
            return $"{MGM_API_BASE_URL}/{url}";
        }

    }
}
