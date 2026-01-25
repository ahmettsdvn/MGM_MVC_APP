using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Helper.TurkeyCityDistrict
{
    public class TurkeyCityDistrictHelper
    {
        /// <summary>
        /// il plakasına göre ilçeleri döner
        /// </summary>
        /// <param name="cityCode"></param>
        /// <returns></returns>
        public static List<Common.Helper.TurkeyCityDistrict.TurkeyCityDistrict> GetDistrictByCityCode(int cityCode)
        {
            List<Common.Helper.TurkeyCityDistrict.TurkeyCityDistrict> response = new List<Common.Helper.TurkeyCityDistrict.TurkeyCityDistrict>();

            // json okundu
            response = ReadJson(cityCode);

            return response;
        }

        /// <summary>
        /// İller döner
        /// </summary>
        /// <returns></returns>
        public static List<Common.Helper.TurkeyCityDistrict.TurkeyCity> GetTurkeyCity()
        {
            List<Common.Helper.TurkeyCityDistrict.TurkeyCity> response = new List<Common.Helper.TurkeyCityDistrict.TurkeyCity>();

            // json okundu
            response = ReadJsonForCity();

            return response;
        }

        /// <summary>
        /// ilce.json dosyasını okur
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        private static List<Common.Helper.TurkeyCityDistrict.TurkeyCityDistrict> ReadJson(int cityCode)
        {
            // ana dizin yolunu bulur
            var baseDir = AppContext.BaseDirectory;
            // ilce.json dosyasının tam yolunu oluşturur
            var filePath = Path.Combine(baseDir, "ilce.json");

            // dosyaın varlığını kontrol eder
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"ilce.json bulunamadı: {filePath}");

            // dosyayı string olarak okur
            var data = File.ReadAllText(filePath);

            // string şeklindeki json veriyi serileştirip pakete çevirdik
            List<Common.Helper.TurkeyCityDistrict.TurkeyCityDistrictOld> json = JsonConvert.DeserializeObject<List<Common.Helper.TurkeyCityDistrict.TurkeyCityDistrictOld>>(data);
            List < Common.Helper.TurkeyCityDistrict.TurkeyCityDistrict > responseList = new List<Common.Helper.TurkeyCityDistrict.TurkeyCityDistrict>();

            if(json != null && json.Count > 0)
            {
                responseList = json.Select(x => new Common.Helper.TurkeyCityDistrict.TurkeyCityDistrict
                {
                    CityId = x.il_id,
                    DistrictName = x.name
                }).Where(i => i.CityId == cityCode).ToList();
            }

            return responseList;
        }



        /// <summary>
        /// il.json dosyasını okur
        /// </summary>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        private static List<Common.Helper.TurkeyCityDistrict.TurkeyCity> ReadJsonForCity()
        {
            // ana dizin yolunu bulur
            var baseDir = AppContext.BaseDirectory;
            // il.json dosyasının tam yolunu oluşturur
            var filePath = Path.Combine(baseDir, "il.json");

            // dosyaın varlığını kontrol eder
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"il.json bulunamadı: {filePath}");

            // dosyayı string olarak okur
            var data = File.ReadAllText(filePath);

            // string şeklindeki json veriyi serileştirip pakete çevirdik
            List<Common.Helper.TurkeyCityDistrict.TurkeyCity> json = JsonConvert.DeserializeObject<List<Common.Helper.TurkeyCityDistrict.TurkeyCity>>(data);

            return json;
        }
    }
}
