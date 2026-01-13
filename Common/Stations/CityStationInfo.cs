using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Stations
{
    /// <summary>
    /// MGM api'sinden çekilen şehir istasyon bilgilerini tutan sınıf
    /// </summary>
    public class CityStationInfo   
    {
        public int? alternatifHadiseIstNo { get; set; }   
        public decimal boylam { get; set; }
        public decimal enlem { get; set; }
        public int gunlukTahminIstNo { get; set; }
        public string il { get; set; }
        public string ilce { get; set; }
        public int ilPlaka { get; set; }
        public int merkezId { get; set; }
        public int oncelik { get; set; }
        public int saatlikTahminIstNo { get; set; }
        public int sondurumIstNo { get; set; }
        public int yukseklik { get; set; }
        public string aciklama { get; set; }
        public int modelId { get; set; }
        public int gps { get; set; }

    }
}
