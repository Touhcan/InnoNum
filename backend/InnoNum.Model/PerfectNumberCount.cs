using System.Text.Json.Serialization;

namespace InnoNum.Model;

public record PerfectNumberCount(
    [property: JsonPropertyName("anzahlVollkommeneZahlen")] int Count);

