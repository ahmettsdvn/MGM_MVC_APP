using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Helper.TurkeyCityDistrict
{
    /// <summary>
    /// ilce.json dosyasını tutan sınıf
    /// </summary>
    public class TurkeyCityDistrict
    {
        /// <summary>
        /// İl Plaka Kodu
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// İlçe Adı
        /// </summary>
        public string DistrictName { get; set; }
    }

    public class TurkeyCityDistrictOld
    {
        /// <summary>
        /// id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// İl Plaka Kodu
        /// </summary>
        public int il_id { get; set; }

        /// <summary>
        /// İlçe Adı
        /// </summary>
        public string name { get; set; }
    }
}
