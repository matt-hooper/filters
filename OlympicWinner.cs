using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class OlympicWinner 
{
    public string Athlete { get; set; }
    [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
    public int? Age { get; set; }
    public string Country { get; set; }
    public int Year { get; set; }
    [JsonProperty("date")]
    [JsonConverter(typeof(CustomDateTimeConverter))]
    public DateTime MedalDate { get; set; }
    public string Sport { get; set; }
    public int Gold { get; set; }
    public int Silver { get; set; }
    public int Bronze { get; set; }
    public int Total { get; set; }

    public string Details() {
        return $"Athlete: {Athlete}. Country: {Country}. Sport: {Sport}. Year: {Year}. Age: {Age}. Gold {Gold}. Silver {Silver}. Bronze {Bronze}. Total: {Total}.";
    }
}

public class CustomDateTimeConverter : IsoDateTimeConverter
{
    public CustomDateTimeConverter()
    {
        base.DateTimeFormat = "dd/MM/yyyy";
    }
}