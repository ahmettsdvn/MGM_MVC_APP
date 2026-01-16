using System;
using System.Collections.Generic;

public class HourlyWeatherForecast
{
    public int istNo { get; set; }
    public string merkez { get; set; }
    public DateTime baslangicZamani { get; set; }

    public List<WeatherForecast> tahmin { get; set; }
}

public class WeatherForecast
{
    public DateTime tarih { get; set; }

    public string hadise { get; set; }

    public int sicaklik { get; set; }

    public int hissedilenSicaklik { get; set; }

    public int nem { get; set; }

    public int ruzgarYonu { get; set; }

    public int ruzgarHizi { get; set; }

    public int maksimumRuzgarHizi { get; set; }
}
