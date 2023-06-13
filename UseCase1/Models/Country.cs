﻿using System.Text.Json.Serialization;

namespace UseCase1.Models
{
    public class Country
    {
        [JsonPropertyName("name")]
        public CountryName? Name { get; set; }

        [JsonPropertyName("tld")]
        public string[]? Tld { get; set; }

        [JsonPropertyName("cca2")]
        public string? Cca2 { get; set; }

        [JsonPropertyName("ccn3")]
        public string? Ccn3 { get; set; }

        [JsonPropertyName("cca3")]
        public string? Cca3 { get; set; }

        [JsonPropertyName("cioc")]
        public string? Cioc { get; set; }

        [JsonPropertyName("independent")]
        public bool? Independent { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("unMember")]
        public bool? UnMember { get; set; }

        [JsonPropertyName("currencies")]
        public Currency? Currencies { get; set; }

        [JsonPropertyName("idd")]
        public Idd? Idd { get; set; }

        [JsonPropertyName("capital")]
        public string[]? Capital { get; set; }

        [JsonPropertyName("altSpellings")]
        public string[]? AltSpellings { get; set; }

        [JsonPropertyName("region")]
        public string? Region { get; set; }

        [JsonPropertyName("subregion")]
        public string? Subregion { get; set; }

        [JsonPropertyName("languages")]
        public Dictionary<string, string>? Languages { get; set; }

        [JsonPropertyName("translations")]
        public Dictionary<string, Dictionary<string, string>>? Translations { get; set; }

        [JsonPropertyName("latlng")]
        public double[]? Latlng { get; set; }

        [JsonPropertyName("landlocked")]
        public bool? Landlocked { get; set; }

        [JsonPropertyName("borders")]
        public string[]? Borders { get; set; }

        [JsonPropertyName("area")]
        public double? Area { get; set; }

        [JsonPropertyName("demonyms")]
        public Dictionary<string, Dictionary<string, string>>? Demonyms { get; set; }

        [JsonPropertyName("flag")]
        public string? Flag { get; set; }

        [JsonPropertyName("maps")]
        public Dictionary<string, string>? Maps { get; set; }

        [JsonPropertyName("population")]
        public long? Population { get; set; }

        [JsonPropertyName("gini")]
        public Dictionary<string, double>? Gini { get; set; }

        [JsonPropertyName("fifa")]
        public string? Fifa { get; set; }

        [JsonPropertyName("car")]
        public Car? Car { get; set; }

        [JsonPropertyName("timezones")]
        public string[]? Timezones { get; set; }

        [JsonPropertyName("continents")]
        public string[]? Continents { get; set; }

        [JsonPropertyName("flags")]
        public Flags? Flags { get; set; }

        [JsonPropertyName("coatOfArms")]
        public CoatOfArms? CoatOfArms { get; set; }

        [JsonPropertyName("startOfWeek")]
        public string? StartOfWeek { get; set; }

        [JsonPropertyName("capitalInfo")]
        public CapitalInfo? CapitalInfo { get; set; }

        [JsonPropertyName("postalCode")]
        public Dictionary<string, string>? PostalCode { get; set; }
    }

    public class CapitalInfo
    {
        [JsonPropertyName("latlng")]
        public double[]? Latlng { get; set; }
    }

    public class CoatOfArms
    {
        [JsonPropertyName("png")]
        public string? Png { get; set; }

        [JsonPropertyName("svg")]
        public string? Svg { get; set; }
    }

    public class Flags : CoatOfArms
    {
        [JsonPropertyName("alt")]
        public string? Alt { get; set; }
    }

    public class Car
    {
        [JsonPropertyName("signs")]
        public string[]? Signs { get; set; }

        [JsonPropertyName("side")]
        public string? Side { get; set; }
    }

    public class CountryName
    {
        [JsonPropertyName("common")]
        public string? Common { get; set; }

        [JsonPropertyName("official")]
        public string? Official { get; set; }

        [JsonPropertyName("nativeName")]
        public Dictionary<string, NativeName>? NativeName { get; set; }
    }

    public class NativeName
    {
        [JsonPropertyName("official")]
        public string? Official { get; set; }

        [JsonPropertyName("common")]
        public string? Common { get; set; }
    }

    public class Currency
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("symbol")]
        public string? Symbol { get; set; }
    }

    public class Idd
    {
        [JsonPropertyName("root")]
        public string? Root { get; set; }

        [JsonPropertyName("suffixes")]
        public string[]? Suffixes { get; set; }
    }
}
